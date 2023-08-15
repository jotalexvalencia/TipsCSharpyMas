using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8b_EstaticoEnConstructor
{
    class MiClase
    {
        private int valor;
        private static int numero;

        public MiClase()
        {
            valor = 20;
            numero = 33;
            Console.WriteLine("Saludos desde el constructor");
        }

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
            Console.WriteLine("valor={0}, numero={1}", valor,numero);
        }

    }
}
