using EventCrud.Models;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace EventCrud.Services;

public class EventService
{
    private List<Event> events;

    public EventService()
    {
        events = new List<Event>();
        DataSeed();
    }


    public Event AddEvent(Event newEvent)
    {
        newEvent.Id = Guid.NewGuid();
        events.Add(newEvent);
        return newEvent;
    }

    public Event GetEventById(Guid id)
    {
        foreach (var eventt in events)
        {
            if (eventt.Id == id)
            {
                return eventt;
            }
        }
        return null;
    }



    public bool DeleteEvent(Guid id)
    {
        var res = GetEventById(id);
        if (res is null)
        {
            return false;
        }
        events.Remove(res);
        return true;
    }


    public bool UpdateEvent(Guid id, Event newEvent)
    {
        var res = GetEventById(id);
        if(res is null)
        {
            return false;
        }
        events[events.IndexOf(res)]=newEvent;
        return true;
    }


    public List<Event> GetEvents()
    {
        return events;
    }


    public List<Event> GetEventsByLocation (string location)
    {
        var sameLocation =new  List<Event>();
        foreach(var eventt in events)
        {
            if(eventt.Location == location)
            {
                sameLocation.Add(eventt);
            }
        }
        return sameLocation;
    }

    public Event GetPopularEvent()
    {
        var newEvent=new Event();
        foreach(var eventt in events)
        {
            if (newEvent.Attendees.Count < eventt.Attendees.Count)
            {
                newEvent = eventt;
            }
        }
        return newEvent;
    }


    public Event GetMaxTaggedEvent()
    {
        var newEvent=new Event();

        foreach (var eventt in events)
        {
            if(eventt.Tags.Count > newEvent.Tags.Count)
            {
                newEvent = eventt;
            }
        }
        return newEvent;
    }

    public bool AddPersonToEvent(Guid id , string name)
    {
        var res = GetEventById(id);
        if (res is null)
        {
            return false;
        }

        events[events.IndexOf(res)].Attendees.Add(name);
        return true;
    }

    public void DataSeed()
    {
        var names = new List<string>();

        names.Add("Aziz");
        names.Add("Asad");
        names.Add("Laziz");
        names.Add("Jasur");
        names.Add("Hasan");
        var tags = new List<string>();
        tags.Add("Ovqatlandik");
        tags.Add("Raqs Tushdik");
        tags.Add("Urishdik");
        var eveent = new Event()
        {
            Id = Guid.NewGuid(),
            Title="Birthday",
            Location="PDP",
            Time=DateTime.Now,
            Description="Birthday of my classmate",
            Attendees=names,
            Tags=tags
        };
        
        events.Add(eveent);

        var names2= new List<string>();
        names2.Add("Aziz");
        names2.Add("Asad");
        names2.Add("Laziz");
        names2.Add("Jasur");
        names2.Add("Hasan");
        names2.Add("Husan");
        var tags2 = new List<string>();
        tags2.Add("Ovqatlandik");
        tags2.Add("Raqs Tushdik");
        tags2.Add("Urishdik");
        tags2.Add("fgdf");
        var eveent2 = new Event()
        {
            Id = Guid.NewGuid(),
            Title = "Var",
            Location = "PDP",
            Time = DateTime.Now,
            Description = "Fight of my friend",
            Attendees = names2,
            Tags = tags2
        };
         events.Add(eveent2);
    }

}
