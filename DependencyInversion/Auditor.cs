using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Auditor
    {
        private Almacen miAlmacen;

        // Estan fuertemente acoplados, solamente puede trabajar con Almacen
        public Auditor(Almacen pAlmacen)
        {
            miAlmacen = pAlmacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;

            foreach (Producto p in miAlmacen.Inventario)
            {
                if(p.Tipo == 0)
                {
                    Console.WriteLine(p);
                    total += p.Costo;
                }
            }

            return total;
        }
    }
}
