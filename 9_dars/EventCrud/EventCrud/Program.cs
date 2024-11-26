using EventCrud.Models;
using EventCrud.Services;
using System.ComponentModel.Design;

namespace EventCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoFront();
        }


        public static void DoFront()
        {
            EventService service = new EventService();

            while (true)
            {
                Console.WriteLine("1.Add Event ");
                Console.WriteLine("2.Delete Event ");
                Console.WriteLine("3.Update Event ");
                Console.WriteLine("4.Read All Events ");
                Console.WriteLine("5.Get Event By Id ");
                Console.WriteLine("6.Get Events By Location ");
                Console.WriteLine("7.Get Popular Event");
                Console.WriteLine("8.Get Max Tagged Event ");
                Console.WriteLine("9.Add Person To Event ");
                Console.Write("Choose : ");
                var choise = int.Parse(Console.ReadLine());
                Console.Clear();

                if (choise == 1)
                {
                    var  eventNew = new Event();

                    Console.Write("Enter Title Of Event : ");
                    eventNew.Title = Console.ReadLine();
                    Console.Write("Enter Location Of Event : ");
                    eventNew.Location = Console.ReadLine();
                    Console.Write("Enter Description Of Event : ");
                    eventNew.Description = Console.ReadLine();
                    Console.Write("Enter Count of Members : ");
                    var count = int.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Enter Attendees Of Event : ");
                        var name= Console.ReadLine();
                        eventNew.Attendees.Add(name);
                    }

                    Console.Write("Enter Count of Tags : ");
                    var tag = int.Parse(Console.ReadLine());
                    for (int i = 0; i < tag; i++)
                    {
                        Console.Write("Enter Tag Of event  : ");
                        var tags = Console.ReadLine();
                        eventNew.Tags.Add(tags);
                    }
                    service.AddEvent(eventNew);
                    Console.WriteLine("Event Added !");
                }

                else if(choise == 2)
                {
                    Console.WriteLine("Enter Deleted Evevnt Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var res=service.DeleteEvent(id);
                    if(res is true)
                    {
                        Console.WriteLine("Deleted !");
                    }
                    else
                    {
                        Console.WriteLine("Id is Wrong !");
                    }
                }

                else if(choise == 3)
                {
                    var eventNew = new Event();

                    Console.WriteLine("Enter Updated Evevnt Id : ");
                    eventNew.Id = Guid.Parse(Console.ReadLine());


                    Console.Write("Enter Title Of Event : ");
                    eventNew.Title = Console.ReadLine();
                    Console.Write("Enter Location Of Event : ");
                    eventNew.Location = Console.ReadLine();
                    Console.Write("Enter Description Of Event : ");
                    eventNew.Description = Console.ReadLine();
                    Console.Write("Enter Count of Members : ");
                    var count = int.Parse(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Enter Attendees Of Event : ");
                        var name = Console.ReadLine();
                        eventNew.Attendees.Add(name);
                    }

                    Console.Write("Enter Count of Tags : ");
                    var tag = int.Parse(Console.ReadLine());
                    for (int i = 0; i < tag; i++)
                    {
                        Console.Write("Enter Tag Of event  : ");
                        var tags = Console.ReadLine();
                        eventNew.Tags.Add(tags);
                    }

                    var res=service.UpdateEvent(eventNew.Id, eventNew);
                    
                    if(res is true)
                    {
                        Console.WriteLine("Updated !");
                    }
                    else
                    {
                        Console.WriteLine("Something is Wrong");
                    }
                }

                else if (choise == 4)
                {
                    var events=service.GetEvents();

                    foreach(var evvent in events)
                    {
                        var str = $"Event Id : {evvent.Id}\nTitle : {evvent.Title}\nLocation : {evvent.Location}\nDescription : {evvent.Description}\n" +
                            $"Time : {evvent.Time}\nAttendees : ";
                        foreach(var name in evvent.Attendees)
                        {
                            str += name + " ";
                        }
                        str += "\nTags : ";
                        foreach(var tag in evvent.Tags)
                        {
                            str += tag + " ";
                        }
                        Console.WriteLine(str);
                        Console.WriteLine("--------------------------------------------");
                    }
                }

                else if(choise == 5)
                {
                    Console.Write("Enter Id : ");
                    var id = Guid.Parse(Console.ReadLine());

                    var res = service.GetEventById(id);
                    if(res is null)
                    {
                        Console.WriteLine("Wrong Id !");
                    }
                    else
                    {
                        var str = $"Event Id : {res.Id}\nTitle : {res.Title}\nLocation : {res.Location}\nDescription : {res.Description}\n" +
                            $"Time : {res.Time}\nAttendees : ";
                        foreach (var name in res.Attendees)
                        {
                            str += name + " ";
                        }
                        str += "\nTags : ";
                        foreach (var tag in res.Tags)
                        {
                            str += tag + " ";
                        }
                        Console.WriteLine(str);


                        Console.WriteLine(str);
                    }
                }

                else if(choise==6)
                {
                    Console.Write("Enter Location : ");
                    var location = Console.ReadLine();

                    var res = service.GetEventsByLocation(location);
                    if(res is null)
                    {
                        Console.WriteLine("Not Found !");
                    }
                    else
                    {
                        foreach(var ev in res)
                        {
                           var  str = $"Event Id : {ev.Id}\nTitle : {ev.Title}\nLocation : {ev.Location}\nDescription : {ev.Description}\n" +
                            $"Time : {ev.Time}\nAttendees : ";
                            foreach (var name in ev.Attendees)
                            {
                                str += name + " ";
                            }
                            str += "\nTags : ";
                            foreach (var tag in ev.Tags)
                            {
                                str += tag + " ";
                            }
                            Console.WriteLine(str);
                            Console.WriteLine("--------------------------------------------");
                        }

                    }
                }
                else if(choise == 7)
                {
                    var res = service.GetPopularEvent();
                    if(res is null)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        var str = $"Event Id : {res.Id}\nTitle : {res.Title}\nLocation : {res.Location}\nDescription : {res.Description}\n" +
                            $"Time : {res.Time}\nAttendees : ";
                        foreach (var name in res.Attendees)
                        {
                            str += name + " ";
                        }
                        str += "\nTags : ";
                        foreach (var tag in res.Tags)
                        {
                            str += tag + " ";
                        }
                        Console.WriteLine(str);
                    }
                }

                else if(choise == 8)
                {
                    var res = service.GetMaxTaggedEvent();
                    if (res is null)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        var str = $"Event Id : {res.Id}\nTitle : {res.Title}\nLocation : {res.Location}\nDescription : {res.Description}\n" +
                            $"Time : {res.Time}\nAttendees : ";
                        foreach (var name in res.Attendees)
                        {
                            str += name + " ";
                        }
                        str += "\nTags : ";
                        foreach (var tag in res.Tags)
                        {
                            str += tag + " ";
                        }
                        Console.WriteLine(str);
                    }
                }
                else if (choise == 9)
                {
                    Console.Write("Enter Post Id : ");
                    var id = Guid.Parse(Console.ReadLine());
                    Console.Write("Enter Person Name : ");
                    var name = Console.ReadLine();

                    var res = service.AddPersonToEvent(id, name);
                    if ( res is true)
                    {
                        Console.WriteLine(res);
                    }
                    else
                    {
                        Console.WriteLine(res);
                    }

                }
                else
                {
                    Console.Clear();
                    continue;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
