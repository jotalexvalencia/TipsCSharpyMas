using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip030ClasesyMetodosParciales
{
    // Creamos una clase parcial
    // En este documentos creamos una parte
    partial class CEjemplo
    {
        private double costo;
        private double impuesto;
        private double total;

        // Propiedades
        public double Costo { get => costo; set => costo = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
        public double Total { get => total; set => total = value; }

        // Definimos un metodo parcial
        // va a trabajar como si fuera un metodo privado
        // no se le puede colocar acceso ni modificadores       
        partial void calculaImpuesto(double pImpuesto);
    }
}
