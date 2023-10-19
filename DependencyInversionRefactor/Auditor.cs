using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor
{
    class Auditor
    {
        private IAuditable miAlmacen;

        // Ahora el auditor ya no esta fuertemente acoplado con el almacen
        public Auditor(IAuditable pAlmacen) 
        { 
            miAlmacen = pAlmacen;
        }

        public double totalesAlimentos()
        { 
            double total = 0;

            IEnumerable<Producto> listado = miAlmacen.ObtenProductos(0);

            foreach (Producto p in listado)
            {
                Console.WriteLine(p);
                total += p.Costo;
            }

            return total;
        }
    }
}
