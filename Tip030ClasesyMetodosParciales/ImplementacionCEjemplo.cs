using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip030ClasesyMetodosParciales
{
    partial class CEjemplo
    {
        public override string ToString()
        {
            // Invocamos el metodo parcial
            calculaImpuesto(0.16);

            return string.Format("El costo es {0}, el impuesto {1} y el total {2}", costo, impuesto, total);
        }

        partial void calculaImpuesto(double pImpuesto)
        {
            impuesto = costo * pImpuesto;
            total = costo + impuesto;            
        }
    }
}