using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip033_ReimplementacionDeInterfazEnHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reimplementación de interfaces en herencia
            CPrueba o1 = new CPrueba(45);
            o1.calcular(12.5);
            Console.WriteLine("-----");
            COtra o2 = new COtra(10);
            Console.WriteLine("-----");
            CTest o3 = new CTest(45);
            o3.calcular(12.5);
            Console.WriteLine("-----");

            // Gracias al polimorfismo podemos usar la version original
            ((CPrueba)o3).calcular(12.5);
        }
    }
}
