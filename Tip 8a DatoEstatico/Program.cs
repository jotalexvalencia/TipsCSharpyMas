using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_8a_DatoEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos tres instancias
            MiClase obj1 = new MiClase();
            MiClase obj2 = new MiClase();
            MiClase obj3 = new MiClase();

            Console.WriteLine("Imprimimos antesd e cambios");
            obj1.muestraDatos();
            obj2.muestraDatos();
            obj3.muestraDatos();

            // cambiamos datos e imprimimos
            obj1.ponValor(3);
            obj2.ponValor(57);
            obj3.ponValor(140);
            Console.WriteLine("Imprimimos con cambios a valor");
            obj1.muestraDatos();
            obj2.muestraDatos();
            obj3.muestraDatos();

            // Cambiamos el numero solo en un objeto
            obj2.ponNumero(300);
            Console.WriteLine("Imprimimos con cambio a número");
            obj1.muestraDatos();
            obj2.muestraDatos();
            obj3.muestraDatos();

        }
    }
}
