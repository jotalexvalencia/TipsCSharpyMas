using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterafaceSegregationRefactor
{
    class MultiAvanzado : IMultiCompleto
    {
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
    }
}
