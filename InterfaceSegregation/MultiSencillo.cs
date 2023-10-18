using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class MultiSencillo : IMultifuncional
    {
        // Necesitamos estos metodos
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }
        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }
        // Estos metodos no los necesitamos
        // Si no colocamos implementacion hay que poner excepcion
        public void Telefono()
        {
            throw new NotImplementedException();
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }
    }
}
