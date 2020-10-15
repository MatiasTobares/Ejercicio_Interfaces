using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Imprimible
{
    class Impresora
    {
        List<Iimprimible> colaDeImpresion = new List<Iimprimible>();
   

        //Este metodo sera llamado en el main principal.
        public void ImprimirTodo()
        {
            foreach(Iimprimible m in colaDeImpresion)
            {
                m.Imprimir();       
            }
        }

        //Metodo de agregar impresion.
        public void AgregarImprimible(Iimprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);

        }
    }
}
