using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tipod_ClaseEstatica
{
    static class MiClase
    {
        private static int valor = 20;
        private static int numero;
        internal static object ponnumero;

        static MiClase()
        {
            numero = 33;
            Console.WriteLine("Saludos desde el constructor");
        } 
        public static void ponValor(int pValor)
        {
            valor = pValor;
        }
        public static void ponNumero(int pNumero)
        {
            numero = pNumero;
        }
        public static void muestraDatos()
        {
            Console.WriteLine("valor={0}, numero={1}",valor,numero);
        }

    }
}
