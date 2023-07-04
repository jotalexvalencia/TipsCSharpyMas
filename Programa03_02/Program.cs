using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0;

            // clase normal

            CCalculadora miCalcu = new CCalculadora(5, 3);
            miCalcu.suma();
            Console.WriteLine("la suma es {0}", miCalcu.R);

            miCalcu.resta();
            Console.WriteLine(" la resta es {0}", miCalcu.R);

            //// Clase con metodos estaticos

            r = CCalculadoraS.suma(6, 9);
            Console.WriteLine("la suma es {0}", r);

            r = CCalculadoraS.resta(45, 67);
            Console.WriteLine("La resta es {0}", r);
        }
    }
}
