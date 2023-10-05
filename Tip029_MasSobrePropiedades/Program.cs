using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip029_MasSobrePropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            CPrueba objeto = new CPrueba(50);

            double pv = objeto.PrecioVenta;
            Console.WriteLine("Precio venta:{0}",pv);

            double imp = objeto.Impuesto;
            Console.WriteLine("Impuesto: {0}", imp);

            objeto.Descuento = 15;
            double pdesc = objeto.Descuento;
            Console.WriteLine("El precio con descuento: {0}", pdesc);

            Console.WriteLine("Objetos en existencia: {0}", objeto.Inventario);

            // no lo permite
            //objeto.Garantia = 2;

            Console.WriteLine("La garantia es de {0} años", objeto.Garantia);

            objeto.ponerGarantia(12345, 2);
            Console.WriteLine("La garantia es de {0} años", objeto.Garantia);
        }
    }
}
