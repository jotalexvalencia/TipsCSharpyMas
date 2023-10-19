using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen miAlmacen = new Almacen();
            double total = 0;

            //0 alimento, 1 medicina, 2 ropa
            miAlmacen.AdicionarProducto(new Producto("Tomate", 0, 15.50));
            miAlmacen.AdicionarProducto(new Producto("Banana", 0, 30));
            miAlmacen.AdicionarProducto(new Producto("Analgesico", 1, 23.80));
            miAlmacen.AdicionarProducto(new Producto("Jeans", 2, 450.99));
            miAlmacen.AdicionarProducto(new Producto("Manzana", 0, 12.38));
            miAlmacen.AdicionarProducto(new Producto("Antiacido", 1, 38.50));
            miAlmacen.AdicionarProducto(new Producto("Blusa", 2, 200.88));

            Console.WriteLine("- - - - - -");

            Auditor miAuditor = new Auditor(miAlmacen);
            total = miAuditor.totalesAlimentos();

            Console.WriteLine("El total de alimentos es {0}", total);
        }
    }
}
