using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterafaceSegregationRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiAvanzado avanzado = new MultiAvanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("- - - - - -");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();            

            Console.WriteLine("- - - - - -");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
        }
    }
}
