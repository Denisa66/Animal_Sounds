using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat(),
            new Wolf() 
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
        }

        Console.ReadLine();
    }
}
