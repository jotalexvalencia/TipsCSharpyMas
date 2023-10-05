using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip031EnumeracionesdeFlags
{
    [Flags]
    //public enum Condimentos
    //{
    //    nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8
    //}

    public enum Condimentos
    {
        nada = 0, Tomate = 1, Lechuga = 2, Cebolla = 4, Queso = 8,
        Basica = Tomate | Lechuga,
        Completa = Tomate | Lechuga | Cebolla| Queso
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            // Colocamos un condimento
            Condimentos misCondimientos = Condimentos.Queso;
            DibujarHamburgueda(misCondimientos);

            // Adicionamos otro condimento
            misCondimientos = misCondimientos | Condimentos.Tomate;
            DibujarHamburgueda(misCondimientos);

            // Adicionamos otros
            misCondimientos = misCondimientos | Condimentos.Lechuga | Condimentos.Cebolla;
            DibujarHamburgueda(misCondimientos);

            // Quitamos un condimentos
            misCondimientos -= Condimentos.Cebolla;
            DibujarHamburgueda(misCondimientos);

            // Limpiamos
            misCondimientos = Condimentos.nada;
            DibujarHamburgueda(misCondimientos);

            // una basica
            misCondimientos = Condimentos.Basica;
            DibujarHamburgueda(misCondimientos);

            // una completa
            misCondimientos = Condimentos.Completa;
            DibujarHamburgueda(misCondimientos);

        }

        public static void DibujarHamburgueda(Condimentos pCond)
        {
            // Dibujamos tapa
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(====)");

            // Verificamos si se tiene tomate
            if((pCond & Condimentos.Tomate) != 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(" ==== ");
            }

            // Verificamos si se tiene lechuga
            if((pCond & Condimentos.Lechuga) != 0)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(" ^^^^ ");
            }

            // Verificamos si se tiene cebolla
            if((pCond & Condimentos.Cebolla) != 0) 
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine(" #### ");
            }

            // Verificamos si se tiene queso
            if((pCond & Condimentos.Queso) != 0)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine(" ---- ");
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ==== ");

            // Dibujamos base
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(====)");

            Console.WriteLine("\r\n ---------- \r\n");
        } 
    }
}
