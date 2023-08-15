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

        public BookService()
        {
            _httpClient = new HttpClient();
        }
        public Task<SuccessMessage> CreateBookAsync(AddBook book)
        {
            var content = JsonConvert.SerializeObject(book);
            var bodyContent = new StringContent(content);

            throw new NotImplementedException();
        }

        public Task<SuccessMessage> DeleteBookAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<SuccessMessage> UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
