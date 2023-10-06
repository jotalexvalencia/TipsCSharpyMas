using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip033_ReimplementacionDeInterfazEnHerencia
{
    class CTest: CPrueba, ICalculable
    {
        double miNumero;

        public CTest(double pNumero)
            :base(pNumero) 
        {
            miNumero = pNumero;
        }

        public void calcular(double pValor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Version de Test {0}", miNumero+pValor);
        }
    }
}
