using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass;

internal class School
{
    public int OpenedYear { get; set; }
    public string Status { get; set; }
    public int Capicity { get; set; }
    public int Raiting { get; set; }
    public int FloorsCount { get; set; }
    public int RoomsCount { get; set; }
    public int Studentscount { get; set; }
    public bool IsPersonal { get; set; }
    public string Specialisty { get; set; }
    public int Number { get; set; }



    public void Display()
    {
        Console.WriteLine($"OpenedYear:{OpenedYear}");
        Console.WriteLine($"Status:{Status}");
        Console.WriteLine($"Capicity:{Capicity}");
        Console.WriteLine($"Raiting:{Raiting}");
        Console.WriteLine($"FloorsCount:{FloorsCount}");
        Console.WriteLine($"RoomsCount:{RoomsCount}");
        Console.WriteLine($"Studentscount:{Studentscount}");
        Console.WriteLine($"IsPersonal:{IsPersonal}");
        Console.WriteLine($"Specialisty:{Specialisty}");
        Console.WriteLine($"Number:{Number}");
        Console.WriteLine("\n");
    }

}
