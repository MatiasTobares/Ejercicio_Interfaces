using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Volador
{
    class Boing747 : Aviones , Ivolador
    {
        int horasVuelo = 13;
        public void volar()
        {
            Console.WriteLine("Estoy volando como un avion...");
            horasVuelo -= 13;
        }
    }
}
