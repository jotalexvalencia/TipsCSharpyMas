using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Fax : IMultifuncional
    {
        // Nos vemos forzados a implementar estos metodos
        public void Imprimir()
        {
            Console.WriteLine("No tengo este servicio");
        }
        public void Escanear()
        {
            Console.WriteLine("No tengo este servicio");
        }
        // Estos metodos si los necesitamos
        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }
    }
}
