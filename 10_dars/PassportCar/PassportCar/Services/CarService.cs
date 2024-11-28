using PersonPasport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonPasport.Services;

public class CarService
{
    private List<Car> cars;

    public CarService()
    {
        cars = new List<Car>();
    }

    public Car AddCar(Car car)
    {
        car.Id = Guid.NewGuid();
        cars.Add(car);
        return car;
    }

    public Car GetCarById(Guid id)
    {
        foreach (var car in cars)
        {
            if (car.Id == id)
            {
                return car;
            }
        }

        return null;
    }


    public bool DeleteCar(Guid id)
    {
        var car = GetCarById(id);
        if (car is null)
        {
            return false;
        }
        cars.Remove(car);
        return true;
    }

    public bool UpdateCar(Car car)
    {
        var result = GetCarById(car.Id);
        if (result is null)
        {
            return false;
        }

        cars[cars.IndexOf(result)] = car;
        return true;
    }

    public List<Car> AllCars()
    {
        return cars;
    }



    public List<Car> GetCarsByPersonId(Guid personId)
    {
        var personCars = new List<Car>();
        foreach (var car in cars)
        {
            if (car.PersonId == personId)
            {
                personCars.Add(car);
            }
        }
        return personCars;
    }


}
