using RestaruantClass;

namespace HomeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Home firstHome = new Home()
            {
                Number = 15,
                Year = 2004,
                Status = "New",
                CoutnOfFloors = 2,
                Adress = "Garden Street 123",
                Raiting = 5,
                OwnersName = "Billy James",
                Price = 999000,
                Capicity = 100,
                CountOfRooms = 20
            };
            
            Home secondHome = new Home()
            {
                Number = 11,
                Year = 2024,
                Status = "New",
                CoutnOfFloors = 6,
                Adress = "Garden Street 101",
                Raiting = 5,
                OwnersName = "James Brain",
                Price = 1000000,
                Capicity = 500,
                CountOfRooms = 60
            };
            Home thirdHome = new Home()
            {
                Number = 5,
                Year = 2021,
                Status = "Old",
                CoutnOfFloors = 1,
                Adress = "Garden Street 56",
                Raiting = 3.5,
                OwnersName = "James Kartes",
                Price = 10000,
                Capicity = 30,
                CountOfRooms = 10
            };

            firstHome.Display();
            secondHome.Display();
            thirdHome.Display();

        }
    }
}
