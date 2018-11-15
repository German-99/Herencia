using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalAcuatico : Animal
    {
        public void Nadar()
        {
            Console.WriteLine("hola soy un" + Nombre + "y estoy nadando");
        }
    }
}
