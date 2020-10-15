using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Volador
{
    class TorreDeControl
    {
        List<Ivolador> voladores = new List<Ivolador>();

        public void vuelenTodos()
        {
            foreach(Ivolador Iv in voladores)
            {
                Iv.volar();
            }
        }


        public void agregarVolador(Ivolador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
