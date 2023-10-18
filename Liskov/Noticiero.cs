using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    class Noticiero
    {
        protected string mensaje;

        public Noticiero(string pMensaje)
        {
            mensaje = pMensaje;
        }

        // Para primera prueba
        //public void Muestra() 
        //{
        //    Console.WriteLine("Desde el noticiero: {0}", mensaje);
        //}

        // Para segunda prueba
        public virtual void Muestra() 
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
