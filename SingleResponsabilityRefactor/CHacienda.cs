using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityRefactor
{
    // Creamos una clase especializada para la otra responsabilidad
    // Ahora cada clase tiene solo una responsabilidad
    class CHacienda
    {
        public static double CalcularImpuesto(CEmpleado pEmpleado)
        {
            return pEmpleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(CEmpleado pEmpleado)
        {
            double imp = CalcularImpuesto(pEmpleado);
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, pEmpleado.Nombre);
        }
    }
}
