using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaruantClass;

internal class Phone
{
    public int PublishedYear { get; set; }
    public string Status { get; set; }
    public int PhoneMemory { get; set; }
    public int Ram { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public double Raiting { get; set; }
    public string Price { get; set; }
    public int CameraMP { get; set; }
    public bool Document { get; set; }



    public void Display()
    {
        Console.WriteLine($"PublishedYear:{PublishedYear}");
        Console.WriteLine($"Status:{Status}");
        Console.WriteLine($"PhoneMemory:{PhoneMemory}");
        Console.WriteLine($"Ram:{Ram}");
        Console.WriteLine($"Model:{Model}");
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Price:{Price}");
        Console.WriteLine($"CameraMP:{CameraMP}");
        Console.WriteLine($"Document:{Document}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine("\n");
    }
}
