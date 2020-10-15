using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Superman superman = new Superman();
            Boing747 boning = new Boing747();
            TorreDeControl torreControl = new TorreDeControl();

            torreControl.agregarVolador(pato);
            torreControl.agregarVolador(superman);
            torreControl.agregarVolador(boning);

            torreControl.vuelenTodos();

            Console.ReadKey();                           
        }
    }
}
