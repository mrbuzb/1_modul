using System.Numerics;
using System.Threading.Tasks.Sources;

namespace ComputerClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer firstComputer = new Computer()
            {
                PublishedYear = 2023,
                Status = "New",
                ComputerMemory = 512,
                Ram = 16,
                Model = "Hp",
                Name = "Victus",
                Raiting = 4.5,
                Price = "900",
                VideoCard = "Core i5",
                Document = true
            };
            Computer secondComputer = new Computer()
            {
                PublishedYear = 2015,
                Status = "Old",
                ComputerMemory = 1,
                Ram = 4,
                Model = "Lenovo",
                Name = "tr 500",
                Raiting = 1.5,
                Price = "200",
                VideoCard = "No",
                Document = false
            };
            Computer thirdComputer = new Computer()
            {
                PublishedYear = 2000,
                Status = "Old",
                ComputerMemory = 4,
                Ram = 2,
                Model = "Lg",
                Name = "lg 5",
                Raiting = 1,
                Price = "100",
                VideoCard = "No",
                Document = false
            };
        }
    }
}
