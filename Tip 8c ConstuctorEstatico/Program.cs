using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8c_ConstuctorEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos dos objetos
            MiClase obj1 = new MiClase();
            MiClase obj2 = new MiClase();

            Console.WriteLine("Sin cambio");
            obj1.muestraDatos();
            obj2.muestraDatos();

            // cambiamos
            obj1.ponValor(400);
            obj2.ponNumero(555);
            Console.WriteLine("Con cambios");
            obj1.muestraDatos();
            obj2.muestraDatos();

            // creamos otra instancia
            MiClase obj3 = new MiClase();
            Console.WriteLine("Despues de la instancia");
            obj1.muestraDatos();
            obj2.muestraDatos();
            obj3.muestraDatos();

        }
    }
}
