using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiavanzado avanzado = new Multiavanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("- - - - - -");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();
            miFax.Imprimir();

            Console.WriteLine("- - - - - -");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            sencillo.Telefono(); // Lanzará la excepción
        }
    }
}
