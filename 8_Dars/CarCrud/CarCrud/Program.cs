using CarCrud.Models;
using CarCrud.Services;

namespace CarCrud;

public class Program
{
    static void Main(string[] args)
    {
        GoFront();
    }

    public static void GoFront()
    {
        CarService carService = new CarService();

        while (true)
        {
            Console.WriteLine("1.AddCar");
            Console.WriteLine("2.DeleteCar");
            Console.WriteLine("3.UpdateCar");
            Console.WriteLine("4.GetCarById");
            Console.WriteLine("5.GetCars");
            Console.Write("Choose : ");
            var choosed=Console.ReadLine();


            if (choosed == "1")
            {
                Car car = new Car();
                Console.Write("Enter Car Model : ");
                car.Model = Console.ReadLine();
                Console.Write("Enter Car Name : ");
                car.Name = Console.ReadLine();
                Console.Write("Enter Car PunlishedDate : ");
                car.PublishedDate =DateOnly.Parse(Console.ReadLine());

                carService.AddCar(car);
                Console.WriteLine("Succesfully Added!\n");
            }

            else if (choosed == "2")
            {
                Console.Write("Enter Deleted Car's Id : ");
                var carId=Guid.Parse(Console.ReadLine());
                var res = carService.DeleteCar(carId);
                if(res is true)
                {
                    Console.WriteLine("Succesfuly Deleted!\n");
                }
                else
                {
                    Console.WriteLine("Wrong ID");
                }
            }

            else if(choosed == "3")
            {
                Car car=new Car();
                Console.Write("Enter Car ID : ");
                car.Id=Guid.Parse(Console.ReadLine());
                Console.Write("Enter Car Model : ");
                car.Model = Console.ReadLine();
                Console.Write("Enter Car Name : ");
                car.Name = Console.ReadLine();
                Console.Write("Enter Car PublishedDate : ");
                car.PublishedDate =DateOnly.Parse(Console.ReadLine());

                var result=carService.UpdateCar(car);
                if(result is true)
                {
                    Console.WriteLine("Updated!\n");
                }
                else
                {
                    Console.WriteLine("SomeThing is Wrong\n");
                }
            }

            else if(choosed=="4")
            {
                Console.Write("Enter Id : ");
                var carId= Guid.Parse(Console.ReadLine());
               var res =  carService.GetCarById(carId);
                if(res is not null)
                {
                    var str = $"ID : {res.Id}\nModel : {res.Model}\nName : {res.Name}\nPublishedDate : {res.PublishedDate}\n";
                }
                else
                {
                    Console.WriteLine("Id is Wrong");
                }
            }

            else if (choosed=="5")
            {
                var cars=carService.GetCars();

                foreach(var car in cars)
                {
                    var info= $"ID : {car.Id}\nModel : {car.Model}\nName : {car.Name}\nPublishedDate : {car.PublishedDate}\n";
                    Console.WriteLine(info);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }



}
