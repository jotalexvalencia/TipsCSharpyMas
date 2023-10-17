using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class CTienda
    {
        private List<CProducto> productos;

        public CTienda(List<CProducto> pProductos)
        {
            productos = pProductos;
        }

        public void calcularInventario()
        {
            double total = 0;

            //foreach (CProducto producto in productos)
            //{
            //    Console.WriteLine(producto);
            //    total += producto.Precio;
            //}

            // Cambio
            foreach (CProducto producto in productos)
            {
                if (producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.8;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
                if (producto.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 1.2;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
            }

            Console.WriteLine("El total en inventario es {0}", total);
        }
    }
}
