using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Sounds;
public class Wolf : IAnimal
{
    public Wolf(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public string MakeSound()
    {
        return "Howl!";
    }
}
