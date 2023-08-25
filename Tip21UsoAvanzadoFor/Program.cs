using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip21UsoAvanzadoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            for (n = 0; n < 5; n++)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Valor final {0}",n);

            for(;n<10; n++)
            {
                Console.WriteLine("->{0}",n);
            }
            for(n=0,m=5;n<5;n++,m--)
            {
                Console.WriteLine("n={0}, m={1}",n,m);
            }
            for (n = 0; n < 5;)
            {
                Console.WriteLine("->{0}", n);
                n++;
            }
            for(n=1,m=1;n%12!=0 && m % 12 != 0; n++, m = m + 3)
            {
                Console.WriteLine("n={0}, m={1}", n, m);
            }
            Console.WriteLine("---------------");
            for (n = 1, m = 1; comparacion(n, m); n++, m = m + 3)
            {
                Console.WriteLine("n={0}, m={1}", n, m);
            }
        }

        public static bool comparacion(int a, int b)
        {
            bool resultado = false;
            if(a%12!=0 && b%12!=0)
                resultado = true;
            else 
                resultado = false;
            return resultado;
        }
    }
}
