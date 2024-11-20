namespace SchoolClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School firstSchool = new School()
            {
                OpenedYear = 2009,
                Status = "New",
                Capicity = 5000,
                Raiting = 3,
                FloorsCount = 6,
                RoomsCount = 100,
                Studentscount = 3500,
                IsPersonal = false,
                Specialisty = "Geography",
                Number = 9
            };
            School secondSchool = new School()
            {
                OpenedYear = 2020,
                Status = "New",
                Capicity = 2000,
                Raiting = 4,
                FloorsCount = 4,
                RoomsCount = 100,
                Studentscount = 1500,
                IsPersonal = true,
                Specialisty = "art",
                Number = 1
            };
            School thirdSchool = new School()
            {
                OpenedYear = 1991,
                Status = "Old",
                Capicity = 3000,
                Raiting = 1,
                FloorsCount = 5,
                RoomsCount = 100,
                Studentscount = 1000,
                IsPersonal = false,
                Specialisty = "Education",
                Number = 99
            };









        }
    }
}
