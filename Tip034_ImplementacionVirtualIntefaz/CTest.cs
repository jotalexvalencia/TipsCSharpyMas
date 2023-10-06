using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip034_ImplementacionVirtualIntefaz
{
    // Notar que a diferencia del tip anterior (33)
    // aqui no indicamos que se implementa la interfaz
    class CTest:CPrueba
    {
        double miNumero;

        public CTest(double pNumero)
            :base(pNumero)
        {
            miNumero = pNumero;
        }

        // Aqui hacemos el override de la implementacion
        public override void calcular(double pValor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Version de Test {0}", miNumero + pValor);
        }
    }
}
