using Bookshop.Helpers;
using Bookshop.Models;
using Bookshop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Controller
{
  
    public class BooksController
    {
        BookService bookService = new BookService();
        //communicates with the service
        public static void Init() //static method
        {
            Console.WriteLine("Hello welcome to The Jitu bookshop");
            Console.WriteLine("1.Add a Book");
            Console.WriteLine("2.View Books");
            Console.WriteLine("3.Update a Book");
            Console.WriteLine("4.Delete a Book");
            var input = Console.ReadLine();
            var validateResults=Validate.Validation(new List<string> { input });
            if (!validateResults)
            {
                BooksController.Init();
            }
            else
            {
                new BooksController().MenuRedirect(input);  //instance method
            }
        }

        public async Task MenuRedirect(string Id)
        {
            switch (Id)
            {
                case "1":
                   await AddnewBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    UpdateBook();
                    break;
                case "4":
                    DeleteBook();
                    break;
                default:
                    BooksController.Init();
                    break;

            }
        }
        public async Task AddnewBook()
        {
            Console.WriteLine("Enter book Title");
            var title = Console.ReadLine();
            Console.WriteLine("Enter book Description");
            var Description = Console.ReadLine();
            Console.WriteLine("Enter book Author");
            var Author = Console.ReadLine();
            Console.WriteLine("Enter book Price");
            var Price = Console.ReadLine();
            var newBook = new AddBook()
            {
                Title=title,
                Description=Description,
                Author=Author,
                Price=Price 
            };
            try
            {
                var res = await bookService.CreateBookAsync(newBook);
                await Console.Out.WriteLineAsync(res.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public async void ViewBooks()
        {
            try
            {
                var books = await bookService.GetAllBooksAsync();
                foreach (var book in books)
                {
                    await Console.Out.WriteLineAsync($"{book.Id} . {book.Title}");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task UpdateBook()
        {

        }
        public async Task DeleteBook()
        {

        }

    }
}
