using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip033_ReimplementacionDeInterfazEnHerencia
{
    class COtra:CPrueba
    {
        public COtra(double pNumero):base(pNumero)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En el constructor de COtra");
            calcular(pNumero);
            Console.WriteLine("Saliendo del constructo de COtra");
        }
    }
}
