using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip014ArreglosComoParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mando = { 4, 5, 1, 6, 8, 7, 3 };
            int[] recibo;
            int n = 0;

            // Mandamos el arreglo
            imprime(mando);

            // Solicitamos el arreglo
            recibo = crea();
            for(n=0; n<recibo.Length;n++)
                Console.Write("{0},", recibo[n]);

            Console.WriteLine();
        }

        public static void imprime (int[] arreglo)
        {
            int n = 0;
            for(n=0;n<arreglo.GetLength(0);n++)// GetLength() obtiene la dimensión del arreglo se usa en matrices 0 fila 1 columna
                Console.Write("{0},", arreglo[n]);

            Console.WriteLine();
        }
        public static int[] crea()
        {
            int[] temp = new int[4];
            int n = 0;
            Random rnd = new Random();
            for (n = 0; n < 4; n++)
                temp[n] = rnd.Next(10);
            return temp;
        }
    }
}
