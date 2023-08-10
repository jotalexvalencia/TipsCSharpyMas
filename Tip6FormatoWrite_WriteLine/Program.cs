using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip6FormatoWrite_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // dar formato write y witeline

            // var
            double miDoble = 123456.7890123;
            int miInt = 637;

            Console.WriteLine("Imp normal");
            Console.WriteLine("entero {0}",miInt);
            Console.WriteLine("doble {0}",miDoble);
            Console.WriteLine("-----");
            Console.WriteLine("Impresiones con formato");
            Console.WriteLine("Moneda {0:C}", miDoble);
            Console.WriteLine("Rellena lugares {0:D5}", miInt);// solo funciona con enteros
            Console.WriteLine("Exponente {0:E}", miDoble);
            Console.WriteLine("Lugares decimales {0:F3}", miDoble);
            Console.WriteLine("Exponente con lugares {0:G5}", miDoble);
            Console.WriteLine("Formato numerico {0:N}",miDoble);
            Console.WriteLine("En Hexadecimal {0:X4}",miInt);
        }
    }
}
