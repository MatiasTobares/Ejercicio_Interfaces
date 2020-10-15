using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Volador
{
    class Superman : SuperHeroe, Ivolador
    {
        int unidadExperienca = 3;
        public void volar()
        {
            Console.WriteLine("Estoy volando como un campeón...");
            unidadExperienca -= 3;
        }
    }
}
