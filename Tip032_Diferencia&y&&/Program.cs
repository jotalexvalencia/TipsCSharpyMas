using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Tip032_Diferencia_y__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diferencia entre & y && | ||

            Stopwatch sw = new Stopwatch();

            int a = 0x08; // 8
            int b = 0x18; // 24

            // & es usada para hacer AND bit por bit, es una operacion aritmetica booleana
            // 00001000 - 8
            // 00011000 - 24
            // 00001000 - 8 - 0x08
            // solo trabaja con bool y con int

            int r = a & b;
            Console.WriteLine("0x{0:x}",r);
            

            // Esto no se puede hacer, porque && es un operador logico
            // r = a && b;

            // & también trabaja con bool y lo toma como de dimension 1 bit
            bool x = true;
            bool y = false;

            bool t = x & y;

            Console.WriteLine(t);

            int m = 5;
            int n = 3;

            sw.Start();
            for (int l = 0; l < 1000000; l++)
            {
                if((m > 30) && (n < 10))
                    Console.WriteLine(":)");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Reset();

            sw.Start();
            sw.Start();
            for (int l = 0; l < 1000000; l++)
            {
                if ((m > 30) & (n < 10))
                    Console.WriteLine(":)");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
    }
}
