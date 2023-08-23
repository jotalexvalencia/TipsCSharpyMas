using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip12ArreglosJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            // arreglos tipo jagged

            int[][] numeros = new int[4][]; // 4 filas

            // instanciar cada renglón
            numeros[0] = new int[3];
            numeros[1] = new int[4];
            numeros[2] = new int[2];
            numeros[3] = new int[3];

            // variables
            int n = 0;
            int m = 0;
            string dato = "";

            // Recorremos el arreglo pidiendo información
            //for(n = 0; n < 4; n++) // ingreso de filas
            //{
            //    for (m = 0; m < numeros[n].GetLength(0); m++) // ingreso de columnas
            //    {
            //        Console.WriteLine("Dame el numero {0} del renglon {1}",m,n);
            //        dato = Console.ReadLine();
            //        numeros[n][m]=Convert.ToInt32(dato);
            //    }
            //    Console.WriteLine();
            //}

            // cuando sabemos los datos otra forma de llenar el arreglo jagged
            numeros[0] = new int[] { 3, 4, 7, 8 };
            numeros[1] = new int[] { 2, 1 };
            numeros[2] = new int[] { 7, 5, 3 };
            numeros[3] = new int[] {4,7,8,9,10,11};

            Console.WriteLine("----------");

            // Imprimimos los datos
            // Recorremos el arreglo pidiendo información
            for (n = 0; n < 4; n++) // ingreso de filas
            {
                for (m = 0; m < numeros[n].GetLength(0); m++) // ingreso de columnas
                {
                    Console.Write("{0}.",numeros[n][m]);
                }
                Console.WriteLine();
            }


        }
    }
}
