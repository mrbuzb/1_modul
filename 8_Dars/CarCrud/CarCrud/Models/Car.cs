using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCrud.Models;

public class Car
{
    public Guid Id { get; set; }
    public  string  Model { get; set; }
    public  string  Name { get; set; }
    public  DateOnly PublishedDate { get; set; }
}
