using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CBaseInventario> productos = new List<CBaseInventario> 
            {
                new CInventarioAlimento(new CProducto("Papas",1,12.5)),
                new CInventarioMedicamento(new CProducto("Analgesico",2,23.40)),
                new CInventarioAlimento(new CProducto("Tomate",1,30)),
                new CInventarioAlimento(new CProducto("Manzana",1,25)),
                new CInventarioMedicamento(new CProducto("Antibiotico",2,89)),
                new CInventarioMedicamento(new CProducto("Antiacido",2,43))
            };

            CTienda miTienda = new CTienda(productos);

            miTienda.calcularInventario();
        }
    }
}
