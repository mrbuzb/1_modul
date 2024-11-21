using CarCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCrud.Services;

public class CarService
{
    private List<Car>Cars;

    public CarService()
    {
        Cars = new List<Car>();
        DataSeed();
    }

    public Car AddCar(Car car)
    {
        car.Id = Guid.NewGuid();
        Cars.Add(car);
        return car;
    }

    public bool UpdateCar(Car car)
    {
        var result = false;
        for(var i=0;i<Cars.Count;i++)
        {
            if (Cars[i].Id==car.Id)
            {
                Cars[i]=car;
                result = true;
                break;
            }
        }
        return result;
    }


    public bool DeleteCar(Guid carid)
    {
        var result = false;
        for(var i=0;i< Cars.Count; i++)
        {
            if (Cars[i].Id == carid)
            {
                Cars.Remove(Cars[i]);
                result = true;
            }
        }
            
        return result;
    }

    public List<Car> GetCars()
    {
        return Cars;
    }

    public Car GetCarById(Guid id)
    {
        foreach(var item in Cars)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }

    public void DataSeed()
    {
        Car firstCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "BMW",
            Model = "M5",
            PublishedDate = DateOnly.Parse("11/11/2011")
        };
        Car secondCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "BMW",
            Model = "M8",
            PublishedDate = DateOnly.Parse("11/11/2020")
        };
        Car thirdCar = new Car()
        {
            Id = Guid.NewGuid(),
            Name = "BMW",
            Model = "M2",
            PublishedDate = DateOnly.Parse("10/11/2016")
        };
        Cars.Add(firstCar);
        Cars.Add(secondCar);
        Cars.Add(thirdCar);

    }


}
