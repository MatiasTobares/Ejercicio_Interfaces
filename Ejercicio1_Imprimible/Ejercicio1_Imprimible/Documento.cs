using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Imprimible
{
    class Documento: Evidencia , Iimprimible
    {
        public void Imprimir()
    {
        Console.WriteLine("Soy un documento de word");
    }
     
    }
}
