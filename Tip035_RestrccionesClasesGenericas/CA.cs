using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip035_RestrccionesClasesGenericas
{
    class CA
    {
        // Colocar los atributos y metodos de la clase

        //public CA(int a, int b)
        //{


        //}

        public override string ToString()
        {
            return string.Format("Desde clase A CA");
        }
    }

    class CB : CA
    {
        // Colocar los atreibutos y metodos de la clase

        public override string ToString()
        {
           string r =base.ToString();
           return string.Format("Desde clase A CB-> " + r);
        }
    }

    interface Iinterfaz
    {
        void metodo();
    }

    class CC : Iinterfaz
    {
        public void metodo()
        {
            Console.WriteLine("Implementacion de la interfaz");
        }

        public override string ToString()
        {
            return string.Format("Desde clase A CC");
        }
    }
}
