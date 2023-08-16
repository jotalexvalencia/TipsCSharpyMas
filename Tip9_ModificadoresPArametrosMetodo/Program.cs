using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip9_ModificadoresPArametrosMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a = 5;
            int b = 8;
            int r = 0;

            int cantidad = 8;
            int sumatoria = 0;
            int factorial = 0;

            double prome = 0.0;

            // Invocamos el metodo normal
            r = SumaNormal(a, b);
            Console.WriteLine("El resultado es {0}",r);

            // Intentamos intercambio por metodo normal
            Console.WriteLine("Antes del intercambio a={0}, b={1}",a,b);
            IntercambioNormal(a, b);
            Console.WriteLine("Después del intercambio a={0}, b={1}",a,b);
            Console.WriteLine();

            // Intentamos Intercambio por referencia
            Console.WriteLine("Antes del intercambio a={0}, b={1}",a,b);
            IntercambioReferencia(ref a, ref b);
            Console.WriteLine("Después del intercambio a={0}, b={1}", a, b);
            Console.WriteLine();

            // Hacemos la invocación para calcular sumatoria y factorial
            Calculador(cantidad, out sumatoria, out factorial);
            Console.WriteLine("Sumatoria={0}, factorial={1}",sumatoria,factorial);
            Console.WriteLine();

            // calcula varios promedios con un numero diferente de parametros
            prome = Promedio(3.5, 6.7, 8.9);
            Console.WriteLine("El promedio es {0}",prome);
            prome = Promedio(8.0, 8.7, 8.8, 10.0, 9.0, 7.8);
            Console.WriteLine("El promedio es {0}", prome);
            prome = Promedio(7.8, 9.0);
            Console.WriteLine("El promedio es {0}", prome);
            Console.WriteLine();
        }

        // Método normal
        public static int SumaNormal(int x, int y)
        {
            int z = 0;
            z = x + y;
            return z;
        }

        // Intento de intercamio con un metodo normal
        public static void IntercambioNormal(int x, int y)
        {
            int temp = 0;

            temp = x;
            x = y;
            y=temp;
        }

        // Intento de intercambio con un metodo por referencia
        public static void IntercambioReferencia(ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
        }
        // Metodo que por medio de out regresa valores
        public static void Calculador(int n, out int s, out int f)
        {
            // se hace necesario asignar valores para s y f
            s = 0;
            f = 1;
            int m = 0;

            for (m=1; m< n; m++)
            {
                s = s + m;
                f = f * m;
            }
        }
        // Metodo que calcular el promedio de cualquier cantidad de parametros
        public static double Promedio(params double[] valores)
        {
            double suma = 0.0;
            double prom = 0.0;
            int n = 0;

            for(n=0; n< valores.Length; n++)
            {
                suma += valores[n];
            }

            prom = suma / valores.Length;

            return prom;
        }

    }
}
