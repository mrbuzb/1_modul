using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerClass;

internal class Computer
{
    public int PublishedYear { get; set; }
    public string Status { get; set; }
    public int ComputerMemory { get; set; }
    public int Ram { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public double Raiting { get; set; }
    public string Price { get; set; }
    public string VideoCard { get; set; }
    public bool Document { get; set; }



    public void Display()
    {
        Console.WriteLine($"PublishedYear:{PublishedYear}");
        Console.WriteLine($"Status:{Status}");
        Console.WriteLine($"ComputerMemory:{ComputerMemory}");
        Console.WriteLine($"Ram:{Ram}");
        Console.WriteLine($"Model:{Model}");
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Price:{Price}");
        Console.WriteLine($"VideoCard:{VideoCard}");
        Console.WriteLine($"Document:{Document}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine("\n");
    }
}
