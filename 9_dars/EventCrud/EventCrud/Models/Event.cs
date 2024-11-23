using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCrud.Models
{
    public class Event
    {
        public  Guid Id { get; set; }
        public  string  Title { get; set; }
        public  string Location { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }= DateTime.Now;
        public List<string>Attendees { get; set; }= new List<string>();
        public List<string> Tags { get; set; } = new List<string>();
    }
}
