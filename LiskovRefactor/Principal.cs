using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string pMensaje)
        {
            mensaje = pMensaje;
        }

        // Lo creamos como método abstracto para que cada version lo implemente
        public abstract void Muestra();
    }
}
