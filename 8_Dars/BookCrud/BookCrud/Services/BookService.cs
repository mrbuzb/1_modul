using BookCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrud.Services;

public class BookService
{
    private List<Book> Books;

    public BookService()
    {
        Books = new List<Book>();
        DataSeed();
    }

    public Book AddBook (Book book)
    {
        book.Id = Guid.NewGuid();
        Books.Add(book);
        return book;
    }

    public bool DeleteBook(Guid bookid)
    {
        var res=false;
        for(int i = 0; i < Books.Count; i++)
        {
            if(Books[i].Id == bookid)
            {
                Books.Remove(Books[i]);
                res = true;
            }
        }
        return res;
    }


    public bool UpdateBook(Book book)
    {
        var res = false;
        for(int i = 0;i < Books.Count;i++)
        {
            if (Books[i].Id == book.Id)
            {
                Books[i]=book;
                res = true;
            }
        }
        return res;
    }

    public List<Book> GetBooks()
    {
        return Books;
    }

    public Book GetById(Guid id)
    {
        var res = new Book();
        for(var i = 0;i< Books.Count;i++)
        {
            if (Books[i].Id == id)
            {
                res = Books[i];
                break;
            }
        }
        return null;
    }

    private void DataSeed()
    {
        Book firstBook = new Book()
        {
            Id = Guid.NewGuid(),
            Name = "Daraxt",
            AuthorName = "Karimbek Hasanov",
            Genre = "Afsona",
            Price = 10000,
            PublishedDate = DateOnly.Parse("11/11/2011")
        };
        Book secondBook = new Book()
        {
            Id = Guid.NewGuid(),
            Name = "Daraxt2",
            AuthorName = "Karimbek Hasanov",
            Genre = "Afsona",
            Price = 20000,
            PublishedDate = DateOnly.Parse("11/11/2012")
        };
        Book thirdBook = new Book()
        {
            Id = Guid.NewGuid(),
            Name = "Daraxt3",
            AuthorName = "Karimbek Hasanov",
            Genre = "Afsona",
            Price = 30000,
            PublishedDate = DateOnly.Parse("11/11/2013")
        };

        Books.Add(firstBook);
        Books.Add(secondBook);
        Books.Add(thirdBook);
    }


}
