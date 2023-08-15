using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8c_ConstuctorEstatico
{
    class MiClase
    {
        private int valor = 20;
        private static int numero;

        static MiClase()
        {
            numero = 33;
            Console.WriteLine("Saludos desde el constructor");
        }

        public void ponValor(int pValor)
        {
            valor= pValor;
        } 
        public void ponNumero(int pNumero)
        {
            numero= pNumero;
        } 
        public void muestraDatos()
        {
            Console.WriteLine("Valor={0}, numero={1}",valor,numero);
        }
    }
}
