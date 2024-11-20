using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    internal class Game
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public string Genre { get; set; }
        public string PublishedDate { get; set; }
        public double Price { get; set; }
        public string language { get; set; }
        public string PlayersCount { get; set; }
        public double Raiting { get; set; }
        public int Downloads { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Status:{Status}");
            Console.WriteLine($"Genre:{Genre}");
            Console.WriteLine($"PublishedDate:{PublishedDate}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"language:{language}");
            Console.WriteLine($"PlayersCount:{PlayersCount}");
            Console.WriteLine($"Raiting:{Raiting}");
            Console.WriteLine($"Downloads:{Downloads}");
        }
    }
}
