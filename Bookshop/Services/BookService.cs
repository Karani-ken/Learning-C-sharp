using Bookshop.Models;
using Bookshop.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Services
{
    //communicating with the database
    public class BookService : IBookInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string _url = "http://localhost:3000/books";
        public BookService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<SuccessMessage> CreateBookAsync(AddBook book)
        {
            var content = JsonConvert.SerializeObject(book);
            var bodyContent = new StringContent(content, Encoding.UTF8,"application/json" );
            var response = await _httpClient.PostAsync(_url, bodyContent);
            if (response.IsSuccessStatusCode)
            {
                return new SuccessMessage { Message = "Book Created Successfully" };
            }

            throw new Exception("Book Creating failed");
        }

        public async Task<SuccessMessage> DeleteBookAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(_url + "/" + id);

            if (response.IsSuccessStatusCode)
            {
                return new SuccessMessage { Message = "Book Deleted Successfully" };
            }

            throw new Exception("Book Deletion failed");
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            var response = await _httpClient.GetAsync(_url);
            var books = JsonConvert.DeserializeObject<List<Book>>(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                return books;
            }
            throw new Exception("can't get the books");
        }

        public async Task<Book> GetBookAsync(string Id)
        {
           var response = await _httpClient.GetAsync(_url+"/" + Id);
            var book = JsonConvert.DeserializeObject<Book>(await response.Content.ReadAsStringAsync());
            if (response.IsSuccessStatusCode)
            {
                return book;
            }
            throw new Exception("can't get the book");
        }

        public async Task<SuccessMessage> UpdateBookAsync(Book book)
        {
            var content = JsonConvert.SerializeObject(book);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(_url + "/" + book.Id,bodyContent);
            if (response.IsSuccessStatusCode)
            {
                return new SuccessMessage { Message = "Book Updated Successfully" };
            }

            throw new Exception("Book Updating failed");
        }
    }
}
