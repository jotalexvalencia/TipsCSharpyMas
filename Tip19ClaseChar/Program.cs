using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip19ClaseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Métodos de la clase char

            string identificacion = "CC.944447214";

            Console.WriteLine("----- IsDigit");
            Console.WriteLine(char.IsDigit('a'));
            Console.WriteLine(char.IsDigit('9'));
            Console.WriteLine(char.IsDigit('.'));
            Console.WriteLine(char.IsDigit("costo 5",6));
            Console.WriteLine(char.IsDigit(identificacion,3));

            Console.WriteLine("----- IsLetter");
            Console.WriteLine(char.IsLetter('F'));
            Console.WriteLine(char.IsLetter('>'));
            Console.WriteLine(char.IsLetter('9'));
            Console.WriteLine(char.IsLetter("Hola 5", 3));
            Console.WriteLine(char.IsLetter(identificacion, 1));

            Console.WriteLine("----- IsWhiteSpace");
            Console.WriteLine(char.IsWhiteSpace("Hola a todos", 3));
            Console.WriteLine(char.IsWhiteSpace("Hola a todos", 4));

            Console.WriteLine("----- IsLetterOrDigit");
            Console.WriteLine(char.IsLetterOrDigit('v'));
            Console.WriteLine(char.IsLetterOrDigit('5'));
            Console.WriteLine(char.IsLetterOrDigit("hola.5",4));

            Console.WriteLine("----- IsPunctuation");
            Console.WriteLine(char.IsPunctuation('F'));
            Console.WriteLine(char.IsPunctuation('.'));
            Console.WriteLine(char.IsPunctuation(':'));
            Console.WriteLine(char.IsPunctuation(','));
            Console.WriteLine(char.IsPunctuation(';'));
            Console.WriteLine(char.IsPunctuation('-'));
            Console.WriteLine(char.IsPunctuation('_'));
            Console.WriteLine(char.IsPunctuation('>'));

            Console.WriteLine("----- IsSymbol");
            Console.WriteLine(char.IsSymbol('F'));
            Console.WriteLine(char.IsSymbol('>'));
            Console.WriteLine(char.IsSymbol('.'));
            Console.WriteLine(char.IsSymbol('&'));
            Console.WriteLine(char.IsSymbol('@'));

            Console.WriteLine("----- ToLower");
            Console.WriteLine(char.ToLower('A'));
            Console.WriteLine(char.ToLower('s'));
            Console.WriteLine(char.ToLower('.'));

            Console.WriteLine("----- ToUpper");
            Console.WriteLine(char.ToUpper('A'));
            Console.WriteLine(char.ToUpper('s'));
            Console.WriteLine(char.ToUpper('.'));

            

        }
    }
}
