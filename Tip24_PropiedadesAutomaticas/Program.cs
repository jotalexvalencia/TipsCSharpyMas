using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip24_PropiedadesAutomaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos instancia
            CPrueba objeto = new CPrueba();

            objeto.MuestraDatos();

            int n = objeto.Valor;
            Console.WriteLine("El valor de n es {0}", n);

            int m = objeto.Costo;
            Console.WriteLine("El costo de m es {0}", m);
        }
    }
}
