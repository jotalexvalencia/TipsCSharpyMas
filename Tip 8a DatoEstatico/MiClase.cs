using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8a_DatoEstatico
{
    class MiClase
    {
        private int valor = 50;
        private static int numero = 10;

        public void ponValor(int pValor)
        {
            valor = pValor;
        }

        public void ponNumero(int pNumero)
        {
            numero = pNumero;
        }

        public void muestraDatos()
        {
            Console.WriteLine("Valor={0}, numero={1},",valor,numero);
        }
    }
}
