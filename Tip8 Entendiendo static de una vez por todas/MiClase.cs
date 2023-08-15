using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip8_Entendiendo_static_de_una_vez_por_todas
{
    class MiClase
    {
        private int valor = 50;
        private static int numero = 10;

        public void saluda()
        {
            Console.WriteLine("Solo saludo si hay instancia de la clase");
        }

        public static void mensaje()
        {
            Console.WriteLine("Puedo dar el mensaje aun sin instancia");
        }

        // El metodo estatico no puede usar un dato normal
        //public static void imprimeValor()
        //{
        //    Console.WriteLine("El valor es {0}", valor);
        //}

        public static void imprimeNumero()
        {
            Console.WriteLine("El numero es {0}", numero);
        }
    }
}
