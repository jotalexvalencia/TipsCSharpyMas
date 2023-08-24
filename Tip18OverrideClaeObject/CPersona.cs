using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip18OverrideClaeObject
{
    class CPersona:Object
    {
        private string nombre;
        private int edad;

        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}, edad: {1}", nombre,edad);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(obj !=null && obj is CPersona)
            {
                CPersona temp = (CPersona)obj;

                if(nombre == temp.nombre && edad == temp.edad)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return nombre.GetHashCode()+edad.GetHashCode();
        }

    }
}
