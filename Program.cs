using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Sounds;

class Program
{
    static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog("Rex"),
            new Cat("Felix"),
            new Wolf("Ghost")
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
