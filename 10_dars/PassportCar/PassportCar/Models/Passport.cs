using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPasport.Models;

public class Passport
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Serie { get; set; }
    public string Jshshr { get; set; }
    public Guid PersonID { get; set; }
}
