using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedRefactor
{
    class CInventarioAlimento : CBaseInventario
    {
        public CInventarioAlimento(CProducto pProducto):base(pProducto)
        {
            
        }
        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
