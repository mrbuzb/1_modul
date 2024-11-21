using BookCrud.Models;
using BookCrud.Services;

namespace BookCrud;

internal class Program
{
    static void Main(string[] args)
    {
        DoFront();
    }

    public static void DoFront()
    {
        BookService bookService = new BookService();

        while (true)
        {
            Console.WriteLine("1.AddBook");
            Console.WriteLine("2.DeleteBook");
            Console.WriteLine("3.UpdateBook");
            Console.WriteLine("4.GetBookById");
            Console.WriteLine("5.GetAllBooks");
            Console.Write("Choise : ");
            var choise = Console.ReadLine();

            if (choise == "1")
            {
                Book book = new Book();
                Console.Write("Enter Book Name : ");
                book.Name = Console.ReadLine();
                Console.Write("Enter Author Name : ");
                book.AuthorName = Console.ReadLine();
                Console.Write("Enter Book's Genre : ");
                book.Genre = Console.ReadLine();
                Console.Write("Enter Book's Price : ");
                book.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter Book's PublishedDate : ");
                book.PublishedDate = DateOnly.Parse(Console.ReadLine());

                bookService.AddBook(book);

                Console.WriteLine("Book Added!");
            }

            else if (choise == "2")
            {
                Console.Write("Enter Deleted Book's Id : ");
                var bookid = Guid.Parse(Console.ReadLine());
                var res = bookService.DeleteBook(bookid);
                if (res is true)
                {
                    Console.WriteLine("Deleted!\n");
                }
                else
                {
                    Console.WriteLine("Id is Wrong");
                }
            }

            else if (choise == "3")
            {
                Book book = new Book();

                Console.Write("Enter Updated Book's Name : ");
                book.Id = Guid.Parse(Console.ReadLine());
                Console.Write("Enter Book Name : ");
                book.Name = Console.ReadLine();
                Console.Write("Enter Author Name : ");
                book.AuthorName = Console.ReadLine();
                Console.Write("Enter Book's Genre : ");
                book.Genre = Console.ReadLine();
                Console.Write("Enter Book's Price : ");
                book.Price = int.Parse(Console.ReadLine());
                Console.Write("Enter Book's PublishedDate : ");
                book.PublishedDate = DateOnly.Parse(Console.ReadLine());

                var res = bookService.UpdateBook(book);
                if (res is true)
                {
                    Console.WriteLine("Updated!");
                }
                else
                {
                    Console.WriteLine("Something Is Goes Wrong!\n");
                }
            }

            else if(choise == "4")
            {
                Console.Write("Enter Id : ");
                var bookid=Guid.Parse(Console.ReadLine());

                var res = bookService.GetById(bookid);
                if(res is not null)
                {
                    var information = $"Id : {res.Id}\nName : {res.Name}\nAuthor Name : {res.AuthorName}\nGenre : {res.Genre}\nPrice : {res.Price}\nPublishedDate : {res.PublishedDate}";
                    Console.WriteLine(information);
                }
                else
                {
                    Console.WriteLine("Wrong Id\n");
                }

            }

            else if (choise == "5")
            {
                var books = bookService.GetBooks();
                foreach (var book in books)
                {
                    Console.WriteLine($"Id : {book.Id}\nName : {book.Name}\nAuthor Name : {book.AuthorName}\nGenre : {book.Genre}\nPrice : {book.Price}\nPublishedDate : {book.PublishedDate}");
                }

            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
