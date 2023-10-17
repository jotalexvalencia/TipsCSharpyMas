using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CProducto> misProductos = new List<CProducto>
            {
                new CProducto("Papas",1,12.5),
                new CProducto("Analgesico",2,23.40),
                new CProducto("Tomate",1,30),
                new CProducto("Manzana",1,25),
                new CProducto("Antibiotico",2,89),
                new CProducto("Antiacido",2,43)
            };

            CTienda miTienda = new CTienda(misProductos);
            miTienda.calcularInventario();
        }
    }
}
