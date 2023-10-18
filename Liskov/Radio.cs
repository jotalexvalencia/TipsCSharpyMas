using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Radio: Noticiero
    {
        public Radio(string pMensaje) :base(pMensaje)
        {
            
        }

        // Para la primera prueba
        //public new void Muestra() 
        //{
        //    Console.WriteLine("Desde el radio: {0}", mensaje);
        //}

        // Para la segunda prueba
        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }
    }
}
