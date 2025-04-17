using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sounds
{
    public interface IAnimal
    {
        string Name { get; }
        string MakeSound();
    }
}
