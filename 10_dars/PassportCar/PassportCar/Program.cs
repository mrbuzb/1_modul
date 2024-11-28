using PersonPasport.Models;
using PersonPasport.Services;
using System;
using System.Reflection.Metadata.Ecma335;

namespace PersonPasport;

internal class Program
{
    static void Main(string[] args)
    {
        DoFront();
    }

    public static void DoFront()
    {

        var carService = new CarService();
        var passportService = new PassportService();
        var personService = new PersonService();
        while (true)
        {

            var car = new Car();
            var passport = new Passport();
            var newPerson = new Person();


            Console.WriteLine("1.Add Person");
            Console.WriteLine("2.Delete Person");
            Console.WriteLine("3.Update Person");
            Console.WriteLine("4.Get All Person");
            Console.WriteLine("5.Get All Cars");
            Console.WriteLine("6.Get All Passports");
            Console.WriteLine("7.Get Person By Id ");
            Console.WriteLine("8.Get Passport By Id ");
            Console.WriteLine("9.Get Car By Id ");
            Console.WriteLine("10.Get Cars  By Person's Id ");
            Console.WriteLine("11.Get Passport  By Person's Id ");


            Console.Write("Option : ");

            var option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {

                Console.Write("Enter Person FirstName : ");
                newPerson.FirstName = Console.ReadLine();
                Console.Write("Enter Person Last Name : ");
                newPerson.LastName = Console.ReadLine();
                Console.Write("Enter Person Location : ");
                newPerson.Location = Console.ReadLine();
                Console.Write("Enter Person Age : ");
                newPerson.Age = int.Parse(Console.ReadLine());
                personService.AddPerson(newPerson);
                if (newPerson.Age >= 16)
                {
                    passport.FirstName = newPerson.FirstName;
                    passport.LastName = newPerson.LastName;
                    Console.Write("Enter Passpor Serie : ");
                    passport.Serie = Console.ReadLine();
                    Console.Write("Enter Passpor JSHSHR : ");
                    passport.Jshshr = Console.ReadLine();
                    passport.PersonID = newPerson.Id;

                    passportService.AddPassport(passport);
                    newPerson.PassportID = passport.Id;

                }
                Console.Write("Cars Count : ");
                var cars = int.Parse(Console.ReadLine());
                if (cars > 0)
                {
                    for (int i = 0; i < cars; i++)
                    {
                        Console.Write("Enter Car Name : ");
                        car.Name = Console.ReadLine();
                        Console.Write("Enter Car Model :");
                        car.Model = Console.ReadLine();
                        Console.Write("Enter Car Price : ");
                        car.Price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Car Color  :");
                        car.Color = Console.ReadLine();
                        car.PersonId = newPerson.Id;
                        carService.AddCar(car);
                        newPerson.Cars.Add(car);
                        car = new Car();


                    }
                }

                personService.UpdatePerson(newPerson);

                Console.WriteLine("Added Succesully !");
            }

            else if (option == "2")
            {
                Console.Write("Enter Deleted Person ID : ");
                var id = Guid.Parse(Console.ReadLine());

                var res = personService.DeletePerson(id);

                if (res is true)
                {
                    Console.WriteLine("Deleted Succesfully!");
                }
                else
                {
                    Console.WriteLine("Error Occured!");
                }
            }

            else if (option == "3")
            {

                Console.Write("Enter Updated Person's Id : ");
                newPerson.Id = Guid.Parse(Console.ReadLine());
                Console.Write("Enter Perspn FirstName");
                newPerson.FirstName = Console.ReadLine();
                Console.Write("Enter Person Last Name : ");
                newPerson.LastName = Console.ReadLine();
                Console.Write("Enter Person Location : ");
                newPerson.Location = Console.ReadLine();
                Console.Write("Enter Person Age : ");
                newPerson.Age = int.Parse(Console.ReadLine());
                if (newPerson.Age >= 16)
                {
                    passport.FirstName = newPerson.FirstName;
                    passport.LastName = newPerson.LastName;
                    passport.PersonID = newPerson.Id;
                    Console.Write("Enter Passpor Serie : ");
                    passport.Serie = Console.ReadLine();
                    Console.Write("Enter Passpor JSHSHR : ");
                    passport.Jshshr = Console.ReadLine();

                    passportService.AddPassport(passport);
                    newPerson.PassportID = passport.Id;
                }
                Console.Write("Cars Count : ");
                var cars = int.Parse(Console.ReadLine());
                if (cars > 0)
                {
                    for (int i = 0; i < cars; i++)
                    {
                        Console.Write("Enter Car Name : ");
                        car.Name = Console.ReadLine();
                        Console.Write("Enter Car Model :");
                        car.Model = Console.ReadLine();
                        Console.Write("Enter Car Price : ");
                        car.Price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Car Color  :");
                        car.Color = Console.ReadLine();
                        carService.AddCar(car);
                        car.PersonId = newPerson.Id;
                    }
                }

                var res = personService.UpdatePerson(newPerson);

                if (res is true)
                {
                    Console.WriteLine("Updated Succesfully !");
                }
                else
                {
                    Console.WriteLine("Error Occured!");
                }
            }

            else if (option == "4")
            {
                var res = personService.GetPersons();

                if (res.Count == 0)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    foreach (var person in res)
                    {
                        var str = $"Id : {person.Id}\nFirstName : {person.FirstName}\nLastName : {person.LastName}\nAge : {person.Age}\nLocation : {person.Location}\nPassposrt's ID :" +
                            $" {person.PassportID}\nCars : ";

                        foreach (var carr in person.Cars)
                        {
                            str += carr.Name + " ";
                        }

                        Console.WriteLine(str);
                    }
                }
            }
            else if (option == "5")
            {
                var res = carService.AllCars();
                if (res.Count == 0)
                {
                    Console.WriteLine("Empty");
                }

                foreach (var carr in res)
                {
                    var str = $"ID : {carr.Id}\nName : {carr.Name}\nModel : {carr.Model}\nPrice : {carr.Price}\nColor : {carr.Color}\nPerson's Id : {carr.PersonId}";
                    Console.WriteLine(str);
                    Console.WriteLine("\n\n");
                }
            }

            else if (option == "6")
            {
                var passports = passportService.GetPassports();
                if (passports.Count == 0)
                {
                    Console.WriteLine("Empty !");
                }
                else
                {
                    foreach (var pass in passports)
                    {
                        var str = $"ID : {pass.Id}\nFirstName : {pass.FirstName}\nLastname : {pass.LastName}\nSerie : {pass.Serie}\n" +
                            $"JSHSHR : {pass.Jshshr}\nPersonID : {pass.PersonID}";
                        Console.WriteLine(str);

                    }
                }
            }

            else if (option == "7")
            {
                Console.Write("Enter Person's Id : ");
                var id = Guid.Parse(Console.ReadLine());

                var person = personService.GetPersonById(id);

                if (person is null)
                {
                    Console.WriteLine("Error Ocured!");
                }
                else
                {
                    var str = $"Id : {person.Id}\nFirstName : {person.FirstName}\nLastName : {person.LastName}\nAge : {person.Age}\nLocation : {person.Location}\nPassposrt's ID :" +
                    $" {person.PassportID}\nCars : ";
                    foreach (var carr in person.Cars)
                    {
                        str += carr.Name + " ";
                    }
                    Console.WriteLine(str);
                }
            }

            else if (option == "8")
            {
                Console.Write("Enter Passport ID :");
                var id = Guid.Parse(Console.ReadLine());

                var pass = passportService.GetPassportById(id);
                if (pass is null)
                {
                    Console.WriteLine("Error Occured !");
                }
                else
                {
                    var str = $"ID : {pass.Id}\nFirstName : {pass.FirstName}\nLastname : {pass.LastName}\nSerie : {pass.Serie}\n" +
                            $"JSHSHR : {pass.Jshshr}\nPersonID : {pass.PersonID}";

                    Console.WriteLine(str);
                }

            }

            else if (option == "9")
            {
                Console.Write("Enter Car Id :");
                var id = Guid.Parse(Console.ReadLine());
                var carr = carService.GetCarById(id);

                if (carr is null)
                {
                    Console.WriteLine("Error Occured");
                }
                else
                {
                    var str = $"ID : {carr.Id}\nName : {carr.Name}\nModel : {carr.Model}\nPrice : {carr.Price}\nColor : {carr.Color}\nPerson's Id : {carr.PersonId}";
                    Console.WriteLine(str);
                }

            }

            else if (option == "10")
            {
                Console.Write("Enter Person's ID : ");
                var id = Guid.Parse(Console.ReadLine());
                var res = carService.GetCarsByPersonId(id);

                if (res.Count == 0)
                {
                    Console.WriteLine("Empty Or Wrong Id");
                }

                else
                {
                    foreach (var carr in res)
                    {
                        var str = $"ID : {carr.Id}\nName : {carr.Name}\nModel : {carr.Model}\nPrice : {carr.Price}\nColor : {carr.Color}\nPerson's Id : {carr.PersonId}";
                        Console.WriteLine(str);
                        Console.WriteLine("\n\n");
                    }
                }
            }

            else if (option == "11")
            {
                Console.Write("Enter Person's ID : ");
                var id = Guid.Parse(Console.ReadLine());
                var pass = passportService.GetPassportByPersonId(id);

                if (pass is null)
                {
                    Console.WriteLine("Error Ocured");
                }
                else
                {
                    var str = $"ID : {pass.Id}\nFirstName : {pass.FirstName}\nLastname : {pass.LastName}\nSerie : {pass.Serie}\n" +
                            $"JSHSHR : {pass.Jshshr}\nPersonID : {pass.PersonID}";
                    Console.WriteLine(str);
                }

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}


