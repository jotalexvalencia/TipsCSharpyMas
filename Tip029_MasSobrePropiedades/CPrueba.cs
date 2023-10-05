using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip029_MasSobrePropiedades
{
    class CPrueba
    {
        private double precioVenta;
        private double precioCompra;
        private double descuento;
        private int garantia;

        // Propiedad calculada
        public double PrecioVenta
        {
            get { return precioCompra * 1.30; }
        }

        public CPrueba(double pPrecioCompra)
        {
            precioCompra = pPrecioCompra;
        }

        // Expresion-bodied properties
        // Propiedades de expresion representada

        public double Impuesto => PrecioVenta * 0.16;

        // Version C#7 permite el set

        public double Descuento
        {
            get => precioCompra * (1 - descuento);
            set => descuento = value / 100;
        }

        // Inicializador de propiedades
        public int Inventario { get; set; } = 30;

        // Accesibilidad

        public int Garantia
        {
            get { return garantia; }
            private set { garantia = value; }
        }

        public void ponerGarantia(int pPassword, int pGarantia)
        {
            if (pPassword == 12345)
                garantia = pGarantia;
        }
    }
}
