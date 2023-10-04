using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip028_InicializadoresDeObjetos
{
    class CPrueba
    {
        public int a;
        public int b;
        public string c;

        public CPrueba()
        {
            
        }

        public CPrueba(string pC)
        {
            c = pC;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", a, b, c);
        }
    }
}
