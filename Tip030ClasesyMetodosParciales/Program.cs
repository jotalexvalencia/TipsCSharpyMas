using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip030ClasesyMetodosParciales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos y metodos parciales
            CEjemplo prueba = new CEjemplo();

            prueba.Costo = 500;

            Console.WriteLine(prueba);
        }
    }
}
