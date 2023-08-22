using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip11UsoDeRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            //Random rnd = new Random();
            //Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);ya lo hace random

            int n = 0;
            int numero = 0;
            double valor = 0.0;
            byte[] bytes = new byte[3];

            // Numero entre cero y 2.147.483.647
            numero = rnd.Next();
            Console.WriteLine(numero);

            // Numero entre cero y menor al que coloque. El colocado debe ser >0 y menor que 2.147.483.647
            numero = rnd.Next(20);
            Console.WriteLine(numero);

            // Numero entre el menor y menor al que sea mayor
            numero = rnd.Next(-15, 10);
            Console.WriteLine(numero);

            // Número double entre 0 y 1
            valor = rnd.NextDouble();
            Console.WriteLine(valor);

            // Llena el arreglo de bytes con valores entre 0 y 255
            rnd.NextBytes(bytes);
            for (n = 0; n < 3; n++)            
                Console.WriteLine(bytes[n]);
            
        }
    }
}
