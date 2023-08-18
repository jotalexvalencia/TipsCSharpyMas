using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Tip010BoxingyUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa que muestra el concepto de bosing y unbosing

            // variable normal
            int valor = 5;

            // hacemos el boxing craendo una referencia
            object boxDato = 7;

            // Esta linea marca error
            //valor = valor + boxDato;

            // Hacemos el unboxing
            int unboxDato = (int)boxDato;
            valor = valor + unboxDato;

            Console.WriteLine(valor);

            Muestra(valor);
            Multiplica(valor);

            // boxing que ocurre en las colecciones
            ArrayList miArray = new ArrayList();

            miArray.Add(5);
            miArray.Add(9);

            // esta linea marca error
            // int resultado = miArray[0] + miArray[1];

            int resultado = (int)miArray[0] + (int)miArray[1];
            Console.WriteLine("El resultado es {0}", resultado);
        }

        // metodo que forza al boxing
        public static void Muestra(object o) 
        {
            Console.WriteLine("Lo que recibi es {0}", o);
        }

        public static void Multiplica(object o)
        {
            // para hacer la operacion debemos lleva a cabo unboxing
            // esto causa error
            //Console.WriteLine("lo que recibi es {0}", o*2);
            int temp = (int)o;
            Console.WriteLine("lo que calcule es {0}", temp*2);
        }
    }
}
