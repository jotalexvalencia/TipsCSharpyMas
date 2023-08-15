using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipod_ClaseEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //MiClase obj1 = new MiClase();

            Console.WriteLine("Sin cambio");
            MiClase.muestraDatos();

            
            MiClase.ponValor(400);
            MiClase.ponNumero(555);
            Console.WriteLine("Con cambios");
            MiClase.muestraDatos();
        }
    }
}
