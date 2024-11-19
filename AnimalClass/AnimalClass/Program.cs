namespace AnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals=new List<Animal>();
            Animal firstAnimal = new Animal()
            {
                BirthCountry ="Australie",
                AnimalName = "Tiger",
                TypeOfAnimal = "Mammal",
                AnimalColor = "Brown",
                AnimalAge = 2,
                AnimalGender = "Male",
                AnimalHeight = 1,
                AnimalWeight = 50,
                AnimalHabitat="Wild",
                AnimalDiet = "Meat"
            };

            Animal secondAnimal = new Animal()
            {
                BirthCountry ="Australie",
                AnimalName = "Lion",
                TypeOfAnimal = "Mammal",
                AnimalColor = "Brown",
                AnimalAge = 5,
                AnimalGender = "Male",
                AnimalHeight = 1,
                AnimalWeight = 80,
                AnimalHabitat="Wild",
                AnimalDiet = "Meat"
            };
            Animal thirdAnimal = new Animal()
            {
                BirthCountry ="Jungle",
                AnimalName = "Bear",
                TypeOfAnimal = "Mammal",
                AnimalColor = "Brown",
                AnimalAge = 3,
                AnimalGender = "Female",
                AnimalHeight = 3,
                AnimalWeight = 100,
                AnimalHabitat="Wild",
                AnimalDiet = "Meat"
            };

            firstAnimal.DisplayInformations();
            secondAnimal.DisplayInformations();
            thirdAnimal.DisplayInformations();

        }
    }
}
