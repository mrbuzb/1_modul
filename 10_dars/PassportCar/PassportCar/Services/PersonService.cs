using PersonPasport.Models;

namespace PersonPasport.Services;

public class PersonService
{
    private List<Person> persons;

    public PersonService()
    {
        persons = new List<Person>();
    }


    public Person AddPerson(Person person)
    {
        person.Id = Guid.NewGuid();

        persons.Add(person);
        return person;
    }


    public Person GetPersonById(Guid id)
    {

        foreach (var person in persons)
        {
            if (person.Id == id)
            {
                return person;
            }
        }
        return null;
    }



    public bool DeletePerson(Guid id)
    {
        var person = GetPersonById(id);
        if (person is null)
        {
            return false;
        }

        persons.Remove(person);
        return true;
    }

    public bool UpdatePerson(Person newPerson)
    {
        var person = GetPersonById(newPerson.Id);
        if (person is null)
        {
            return false;
        }

        persons[persons.IndexOf(person)] = newPerson;
        return true;
    }

    public List<Person> GetPersons()
    {
        return persons;
    }


}
