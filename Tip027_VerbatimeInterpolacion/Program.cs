using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip027_VerbatimeInterpolacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabajo con cadenas

            // Verbatim, coloca el contenido de la cadena de forma literal
            // ignora los codigos/secuencias de escape

            string a = "hola a \todos";
            Console.WriteLine(a);

            string b = @"hola a \todos";
            Console.WriteLine(b);

            string c = @"Permite usar
                        nultiples lines
                        a la vez";
            Console.WriteLine(c);

            Console.WriteLine("---------");

            // Interpolación
            // pueden tener expresiones adentro de la cadena que seran evaluadas 
            // y convertidas a cadenas
            // las expresiones van entre llaves { }

            int n = 5, m = 6;

            string d = $"La interpolacion {n*m} da el resultado";
            Console.WriteLine(d);

            string e = $"El valor dado {DaValor()} por la funcion";
            Console.WriteLine(e);

            Console.WriteLine("---------");

            string f = $@"Mezclamos lod dos
                        Evalua {DaValor() * n - m}
                        en varias lineas";

            Console.WriteLine(f);
        }

        public static int DaValor()
        {
            return 15;
        }
    }
}
