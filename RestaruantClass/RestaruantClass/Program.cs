namespace RestaruantClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaruant firstRestaruant = new Restaruant()
            {
                RestaruantName = "AlBurj",
                OpenedYear = 2022,
                TypeOfRestaruant = "Italian",
                MainMeal = "Kebab",
                Adress = "Dubai",
                Raiting = 10,
                OpeningTime = "08:00",
                ClosingTime = "21:00",
                Dilevry = true,
                Capisity = 900
            };
            Restaruant secondRestaruant = new Restaruant()
            {
                RestaruantName = "Bella Italian",
                OpenedYear = 1234,
                TypeOfRestaruant = "Italian",
                MainMeal = "NonKebab",
                Adress = "Uzbekistan",
                Raiting = 2.5,
                OpeningTime = "08:00",
                ClosingTime = "21:00",
                Dilevry = false,
                Capisity = 3
            };
            Restaruant thirdRestaruant = new Restaruant()
            {
                RestaruantName = "Bella",
                OpenedYear = 1200,
                TypeOfRestaruant = "Brazilian",
                MainMeal = "Soup",
                Adress = "Paris",
                Raiting = 5.3,
                OpeningTime = "08:00",
                ClosingTime = "21:00",
                Dilevry = false,
                Capisity = int.MaxValue
            };

            thirdRestaruant.Display();
        }
    }
}
