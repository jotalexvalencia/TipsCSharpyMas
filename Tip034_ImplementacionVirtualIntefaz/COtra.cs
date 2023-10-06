using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip034_ImplementacionVirtualIntefaz
{
    // Esta clase NO hace override a la implementacion de la interefaz
    class COtra:CPrueba
    {
        public COtra(double pNumero)
            :base(pNumero)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En el constructor de COtra");
            calcular(pNumero);
            Console.WriteLine("Saliendo del constructor de COtra");
        }
    }
}
