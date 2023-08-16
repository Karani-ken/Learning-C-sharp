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
        public async static Task Init() //static method
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
               await BooksController.Init();
            }
            else
            {
                await new BooksController().MenuRedirect(input);  //instance method
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
                    await ViewBooks();
                    break;
                case "3":
                   await UpdateBook();
                    break;
                case "4":
                   await  DeleteBook();
                    break;
                default:
                   BooksController.Init();
                    break;

            }
        }
        public async Task AddnewBook()
        {
            Console.WriteLine("Enter book Title");
            string Booktitle = Console.ReadLine();
            Console.WriteLine("Enter book Description");
            string Bookdesc = Console.ReadLine();
            Console.WriteLine("Enter book Author");
            string BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter book Price");
            string Bookprice = Console.ReadLine();
            var newBook = new AddBook()
            {
                Title=Booktitle,
                Description=Bookdesc,
                Author= BookAuthor,
                Price=Bookprice
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
        public async Task ViewBooks()
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
            await ViewBooks();
            Console.WriteLine("Enter the Id of the book tou want to edit");
            var id = Console.ReadLine();
            Console.WriteLine("Enter book Title");
            string Booktitle = Console.ReadLine();
            Console.WriteLine("Enter book Description");
            string Bookdesc = Console.ReadLine();
            Console.WriteLine("Enter book Author");
            string BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter book Price");
            string Bookprice = Console.ReadLine();
            var updatedBook = new Book()
            {
                Id=id,
                Title = Booktitle,
                Description = Bookdesc,
                Author = BookAuthor,
                Price = Bookprice
            };
            try
            {
               var res = await bookService.UpdateBookAsync(updatedBook);
                await Console.Out.WriteLineAsync(res.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task DeleteBook()
        {
            await ViewBooks();
            Console.WriteLine("Enter the Id of the book tou want to edit");
            var id = Console.ReadLine();
            try
            {
                var res = await bookService.DeleteBookAsync(id);
                await Console.Out.WriteLineAsync(res.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
