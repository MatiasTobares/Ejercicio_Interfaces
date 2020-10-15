using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Volador
{
    class Pato : Animal, Ivolador
    {
        int energia = 5;

        public void volar()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
            energia -= 5;
        }
    }
}
