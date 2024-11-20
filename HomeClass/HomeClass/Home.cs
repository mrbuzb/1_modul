using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaruantClass;

internal class Home
{
    public int Number { get; set; }
    public int Year { get; set; }
    public string Status { get; set; }
    public int CoutnOfFloors { get; set; }
    public string Adress { get; set; }
    public double Raiting { get; set; }
    public string OwnersName { get; set; }
    public double Price { get; set; }
    public int Capicity { get; set; }
    public int CountOfRooms { get; set; }



    public void Display()
    {
        Console.WriteLine($"Number:{Number}");
        Console.WriteLine($"Year:{Year}");
        Console.WriteLine($"Status:{Status}");
        Console.WriteLine($"CoutnOfFloors:{CoutnOfFloors}");
        Console.WriteLine($"Adress:{Adress}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine($"OwnersName:{OwnersName}");
        Console.WriteLine($"Price:{Price}");
        Console.WriteLine($"Capicity:{Capicity}");
        Console.WriteLine($"CountOfRooms:{CountOfRooms}");
        Console.WriteLine("\n");
    }
}
