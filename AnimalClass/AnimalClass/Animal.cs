using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass;

public class Animal
{
    public string AnimalName { get; set; }

    public int AnimalAge { get; set; }

    public string AnimalColor { get; set; }

    public string TypeOfAnimal { get; set; }

    public int AnimalHeight { get; set; }

    public int AnimalWeight { get; set; }

    public string BirthCountry { get; set; }

    public string AnimalHabitat { get; set; }

    public string AnimalDiet { get; set; }

    public string AnimalGender { get; set; }

    public void DisplayInformations()
    {
        var informations = $"Name:{AnimalName}\nAge:{AnimalAge}\nColor:{AnimalColor}\n" +
            $"Type:{TypeOfAnimal}\nHeight:{AnimalHeight}\nWeight:{AnimalWeight}\nCountry:{BirthCountry}\nHabitat:{AnimalHabitat}\n" +
            $"Diet:{AnimalDiet}\nGender:{AnimalGender}\n ";
        Console.WriteLine(informations);
    }
}
