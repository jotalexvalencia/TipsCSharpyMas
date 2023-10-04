using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip028_InicializadoresDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializadores de objeto
            // Permite colcoar valores facilmente durante la construcción
            // Solo se usa con variables publicas
            // Pone en riesgo el encapsulamiento

            // Inicilizamos
            CPrueba p1 = new CPrueba { a = 1, b = 2, c = "Hola a todos" };

            Console.WriteLine(p1);

            CPrueba p2 = new CPrueba("Saludos") { a = 5, b = 10 };

            Console.WriteLine(p2);
        }
    }
}
