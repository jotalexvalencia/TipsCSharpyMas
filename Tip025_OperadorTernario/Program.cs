using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip025_OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operador ternario
            // condición ? V : F

            int a = 15;
            int b = 3;
            int r = 0;

            // Selecciona el mayor
            r=(a>b)?a:b;
            Console.WriteLine("El mayor es {0}",r);

            // LLevamos a cabo una asignación
            r = (a < 6) ? a = 10 : a = -10;
            Console.WriteLine("a = {0}, r = {1}", a, r);

            // Hacemos incremento
            r = (a > 5)? a++:b++;
            Console.WriteLine("a={0}, b={1}, r={2}",a,b,r);

            // Hacemos invocacion a un metodo
            r = (a < 0) ? mensaje() : 0;
            Console.WriteLine("r={0}", r);
        }

        public static int mensaje()
        {
            Console.WriteLine("Hola");
            return 50;
        }
    }
}
