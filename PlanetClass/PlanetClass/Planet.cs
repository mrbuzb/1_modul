using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetClass;

internal class Planet
{
    public  string Name { get; set; }
    public  int Population { get; set; }
    public  string MainArea { get; set; }
    public  string Creatures { get; set; }
    public  int ProximitySun { get; set; }
    public  int Length { get; set; }
    public  int Degree { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Population:{Population}");
        Console.WriteLine($"MainArea:{MainArea}");
        Console.WriteLine($"Creatures:{Creatures}");
        Console.WriteLine($"ProximitySun:{ProximitySun}");
        Console.WriteLine($"Length:{Length}");
        Console.WriteLine($"Degree:{Degree}");
    }
}
