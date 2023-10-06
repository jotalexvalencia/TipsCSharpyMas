using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip034_ImplementacionVirtualIntefaz
{
    class CPrueba: ICalculable
    {
        private double n;

        public CPrueba(double pValor)
        {
            n = pValor;
        }

        // Implementación de ICalculable
        // Hay que notar que la estamos marcando como virtual
        // Por default las implementaciones son sealed
        public virtual void calcular(double pNumero)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Estoy en CPrueba {0}", n * pNumero);
        }
    }
}
