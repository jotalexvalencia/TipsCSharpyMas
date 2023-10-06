using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip034_ImplementacionVirtualIntefaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementación virtual de interfaces
            Console.WriteLine("<<< Implementacion virtual >>");

            CPrueba o1 = new CPrueba(45);
            o1.calcular(12.5);
            Console.WriteLine("-----");
            COtra o2 = new COtra(10);
            Console.WriteLine("-----");
            CTest o3 = new CTest(45);
            o3.calcular(12.5);
            Console.WriteLine("-----");
        }
    }
}
