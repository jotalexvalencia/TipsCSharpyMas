using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip036Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            //      00001010
            // 0    00010100    <<1

            //      00001010
            //      00000101 0  >>1

            int n = 5;
            string binario = "";

            binario = Convert.ToString(n,2).PadLeft(8, '0');
            Console.WriteLine("Bin:{0}, Dec:{1}", binario, n);

            // Hacemos shift a la izquierda por 1 bit
            n = n << 1;
            binario = Convert.ToString(n, 2).PadLeft(8, '0');
            Console.WriteLine("Bin:{0}, Dec:{1}", binario, n);

            // Hacemos shift a la izquierda por 3 bit
            n = n << 3;
            binario = Convert.ToString(n, 2).PadLeft(8, '0');
            Console.WriteLine("Bin:{0}, Dec:{1}", binario, n);

            Console.WriteLine("- - - - - -");

            // Hacemos shift a la derecha por 2 bit
            n = n >> 2;
            binario = Convert.ToString(n, 2).PadLeft(8, '0');
            Console.WriteLine("Bin:{0}, Dec:{1}", binario, n);

            // Hacemos shift a la derecha por 3 bit
            n = n >> 3;
            binario = Convert.ToString(n, 2).PadLeft(8, '0');
            Console.WriteLine("Bin:{0}, Dec:{1}", binario, n);

        }
    }
}
