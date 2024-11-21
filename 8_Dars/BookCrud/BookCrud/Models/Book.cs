using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCrud.Models;

public class Book
{
    public Guid Id{ get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public string Genre { get; set; }
    public int Price { get; set; }
    public DateOnly PublishedDate { get; set; }

}
