using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPasport.Models;

public class Person
{
    public Guid Id { get; set; }

    public int Age { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Location { get; set; }

    public Guid PassportID { get; set; }

    public List<Car> Cars { get; set; } = new List<Car>();
}
