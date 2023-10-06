using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip033_ReimplementacionDeInterfazEnHerencia
{
    class CPrueba : ICalculable
    {
        private double n;

        public CPrueba(double pValor)
        {
            n = pValor;
        }

        // Implementacion de ICalculable
        public void calcular(double pNumero)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Estoy en CPrueba {0}", n * pNumero);
        }
    }
}
