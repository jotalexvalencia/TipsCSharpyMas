using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip24_PropiedadesAutomaticas
{
    class CPrueba
    {
        private int valor;

        // Propiedad tradicional

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        // Propiedad automatica

        public int Costo { get; set; } = 5;

        public CPrueba()
        {
            valor = 10;
        }

        public void MuestraDatos()
        {
            Console.WriteLine("Valor es = {0}, Costo es {1}",valor,Costo);
        }
    }
}
