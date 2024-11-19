using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaruantClass;

internal class Restaruant
{
    public string  RestaruantName { get; set; }
    public int  OpenedYear { get; set; }
    public string  TypeOfRestaruant { get; set; }
    public string  MainMeal { get; set; }
    public string  Adress { get; set; }
    public double  Raiting { get; set; }
    public string  OpeningTime { get; set; }
    public string  ClosingTime { get; set; }
    public bool  Dilevry { get; set; }
    public int  Capisity { get; set; }



    public void Display()
    {
        Console.WriteLine($"Name:{RestaruantName}");
        Console.WriteLine($"OpenedYear:{OpenedYear}");
        Console.WriteLine($"Type:{TypeOfRestaruant}");
        Console.WriteLine($"MainMeal:{MainMeal}");
        Console.WriteLine($"Adress:{Adress}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine($"OpeningTime:{OpeningTime}");
        Console.WriteLine($"ClosingTime:{ClosingTime}");
        Console.WriteLine($"Dilevry:{Dilevry}");
        Console.WriteLine($"Capisity:{Capisity}");
    }
}
