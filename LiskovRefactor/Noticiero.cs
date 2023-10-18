using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    class Noticiero:Principal
    {
        public Noticiero(string pMensaje) :base(pMensaje)
        {
            
        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
