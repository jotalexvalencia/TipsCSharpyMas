using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip20ClaseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Hola, saludos a todos!!!!!!!!!!!!!!!!";
            // verificamos si hay una subcadena
            bool tiene = mensaje.Contains("saludos");
            Console.WriteLine(tiene);
            Console.WriteLine("-------------------");
            // verificamos si termina en una subcadena en particular
            bool termina = mensaje.EndsWith(".");
            Console.WriteLine(termina);
            Console.WriteLine("-------------------");
            // creamos una cadena por medio de formato
            int edad = 20;
            string mensaje2 = String.Format("La persona tiene {0} años",edad);
            Console.WriteLine(mensaje2);
            Console.WriteLine("-------------------");
            // encontramos el lugar donde aparece determinado caracter por primera vez
            int indice = 0;
            indice = mensaje.IndexOf('s');
            Console.WriteLine("La s aparece en el índice {0}",indice);
            // encontramos el lugar donde aparece una cadena
            indice = mensaje2.IndexOf("tiene");
            Console.WriteLine("La palabra tiene aparece en el índice {0}", indice);
            // encontrar el lugar donde aparece por última vez determinado caracer
            indice = mensaje.LastIndexOf('a');
            Console.WriteLine("La a aparece por último en el índice {0}", indice);
            Console.WriteLine("-------------------");
            // indicamos la longitud y se llena con espacios
            string mensaje3 = "Programando";
            string pad = mensaje3.PadLeft(15);
            Console.WriteLine(pad);
            Console.WriteLine("-------------------");
            // removemos caracteres
            string remover = mensaje.Remove(7);
            Console.WriteLine(remover);
            Console.WriteLine("-------------------");
            // reemplazamos caracteres
            string reemplazo = mensaje.Replace('a', 'o');
            Console.WriteLine(reemplazo);
            reemplazo = mensaje.Replace("saludos", "regalos");
            Console.WriteLine(reemplazo);
            Console.WriteLine("-------------------");
            // dividimos la cadena usando espacios
            string[] palabras = mensaje.Split(new char[] { ' ' });
            foreach (var s in palabras)
            {
                Console.WriteLine(s);
                Console.WriteLine("-------------------");
            }
            // verificamos si la cadena empieza con una cadena en particular
            bool empieza = mensaje.StartsWith("hola");
            Console.WriteLine(empieza);
            Console.WriteLine("-------------------");
            // obtenemos una subcadena desde un índice hasta otro
            string subcadena = mensaje.Substring(7, 12);
            Console.WriteLine(subcadena);
            Console.WriteLine("-------------------");
            // mandamos a minúsculas
            string mensaje4 = "ESTE mensaje tiene Mayúsculas";
            string minusculas = mensaje4.ToLower();
            Console.WriteLine(minusculas);
            // mandamos a mayúsculas
            string mayusculas = minusculas.ToUpper();
            Console.WriteLine(mayusculas);
            Console.WriteLine("-------------------");
            // eliminamos exceso de caracteres TrimEnd, TrimStart
            string limpio = mensaje.Trim(new char[] { '!' });
            Console.WriteLine(limpio);
            Console.WriteLine("-------------------");
        }
    }
}
