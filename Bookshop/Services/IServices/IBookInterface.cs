using Bookshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Services.IServices
{
    public interface IBookInterface
    {
        //Add a book
        Task<SuccessMessage> CreateBookAsync(AddBook book);
        //update a book
        Task<SuccessMessage> UpdateBookAsync(Book book);
        //delete a book
        Task<SuccessMessage> DeleteBookAsync(string id);
        //get a book
        Task<Book> GetBookAsync(string Id);
        //Get all Books
        Task<List<Book>> GetAllBooksAsync();

    }
}
