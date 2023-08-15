using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8b_EstaticoEnConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos 2 objetos
            MiClase obj1 = new MiClase();
            MiClase obj2 = new MiClase();

            Console.WriteLine("Sin cambio");
            obj1.muestraDatos();
            obj2.muestraDatos();

            //cambiamos
            obj1.ponValor(400);
            obj2.ponNumero(555);
            Console.WriteLine("Con cambios");
            obj1.muestraDatos();
            obj2.muestraDatos();

            // Creamos otra instancia
            // Resetea el dato estatico
            MiClase obj3 = new MiClase();
            Console.WriteLine("Después de la instancia");
            obj1.muestraDatos();
            obj2.muestraDatos();
            obj3.muestraDatos();
        }
    }
}
