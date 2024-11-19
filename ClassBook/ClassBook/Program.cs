using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass;

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public string Genre { get; set; }
    public string PublishedDate { get; set; }
    public double Price { get; set; }
    public string language { get; set; }
    public int Code { get; set; }
    public int Raiting { get; set; }
    public string publisher { get; set; }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"Genre:{Genre}");
        Console.WriteLine($"language:{language}");
        Console.WriteLine($"PageCount:{PageCount}");
        Console.WriteLine($"publisher:{publisher}");
        Console.WriteLine($"Code:{Code}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine($"PublishedDate:{PublishedDate}");
        Console.WriteLine($"Price:{Price}");
    }


}
