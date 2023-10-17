using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Juan", "Programador", 23, 18000);

            Console.WriteLine(empleado);
            Console.WriteLine(CHacienda.CalcularImpuesto(empleado));
            CHacienda.PagarImpuesto(empleado);
        }
    }
}
