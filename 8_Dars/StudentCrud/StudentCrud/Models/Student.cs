using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrud.Models;

public class Student
{
    public Guid Id { get; set; }
    public  string  FirstName { get; set; }
    public  string  LastName { get; set; }
    public  DateOnly  BirthDate { get; set; }
    public string University { get; set; }
    public string PhoneNumber { get; set; }


}
