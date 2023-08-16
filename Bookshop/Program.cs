using Bookshop.Controller;

class program
{
    public async static Task Main()
    {
        await BooksController.Init();
    }
}
