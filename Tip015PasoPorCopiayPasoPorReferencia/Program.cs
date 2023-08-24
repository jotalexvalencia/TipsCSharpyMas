using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip015PasoPorCopiayPasoPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("En main antes de invocar a={0}, b={1}",x,y);
            intercambioCopia(x, y);
            Console.WriteLine("En main después de invocar a={0}, b={1}", x,y);

            Console.WriteLine("\r\n--------\r\n");

            Console.WriteLine("En main antes de invocar a={0}, b={1}",x, y);
            intercambioRef(ref x, ref y);
            Console.WriteLine("En main después de invocar a={0}, b={1}", x, y);


        }

        public static void intercambioCopia(int a, int b)
        {
            Console.WriteLine("     En intCopia entra con a={0}, b={1}",a,b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("     En intCopia sale con a={0}, b={1}",a,b);
        }
        public static void intercambioRef(ref int a, ref int b)
        {
            Console.WriteLine("     En intRef entra con a={0}, b={1}", a,b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("     En intRef sale con a={0}, b={1}",a,b);
        }
    }
}
