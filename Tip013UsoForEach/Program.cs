using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip013UsoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            ArrayList ciudades = new ArrayList();
            int[] valores = new int[4];

            // Llenamos la información
            ciudades.Add("New York");
            ciudades.Add("Londres");
            ciudades.Add("Paris");
            ciudades.Add("Pekin");
            ciudades.Add("Moscu");

            valores[0] = 5;
            valores[1] = 9;
            valores[2] = 7;
            valores[3] = 10;

            // Mostramos la iteración
            foreach (string cd in ciudades)
            {
                Console.WriteLine("La ciudad es {0}", cd);
            }

            foreach (int numero in valores)
            {
                Console.WriteLine("El número es {0}", numero);
            }

            foreach(var ciudad in ciudades)
                Console.WriteLine("ciudad {0} con var", ciudad);
            foreach(var num in valores)
                Console.WriteLine("valor {0} con var", num);
        }
    }
}
