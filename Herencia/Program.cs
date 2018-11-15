using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro Kanguro = new Kanguro();

            Animal tiburon = new AnimalAcuatico();
            tiburon.Nombre = "Tiburon";
            ((AnimalAcuatico)tiburon).Nadar();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            delfin.Comer();
            delfin.Nadar();

            elefante.Caminar();

            Console.ReadLine();
        }
    }
}
