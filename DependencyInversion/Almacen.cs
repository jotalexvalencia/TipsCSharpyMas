using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Almacen
    {
        private List<Producto> inventario;

        // Nos vemos forzados a crear la propiedad para que se pueda contar el inventario
        // Al ser una propiedad de tipo List forzamos a Auditor a trabajar con List
        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }
    }
}
