using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tips4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texto normal");
            impresiones(5);

            Console.WriteLine("Color de la fuente");
            Console.ForegroundColor = ConsoleColor.Green;
            impresiones(5);

            // limpiamos la consola
            Console.Clear();

            Console.WriteLine("Color del fondo");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            impresiones(5);

            Console.WriteLine("Colocamos cuantas columnas");
            Console.BufferWidth = 1024;
            impresiones(5);

            Console.WriteLine("Colocamos los renglones");
            Console.BufferHeight = 1024;
            impresiones(15);

            Console.Clear();

            Console.WriteLine("Colocamos el ancho de la ventana");
            Console.WindowWidth = 100;
            impresiones(15);

            Console.WriteLine("Colocamos el alto de la ventana");
            Console.WindowHeight = 40;
            impresiones(15);

            Console.Clear();

            Console.WriteLine("colocamos la ventana en una posición");
            Console.WindowWidth = 80;
            Console.WindowHeight = 20;
            impresiones(5);
            Console.WindowLeft = 5;
            Console.WindowTop = 2;

        }

        public static void impresiones(int n)
        {
            int x = 0;
            int y = 0;

            for (x = 0;  x < n; x++)
            {
                for (y= 0; y< 100; y++)
                    Console.WriteLine(y % 10);

                Console.WriteLine();

            }
        }
    }
}
