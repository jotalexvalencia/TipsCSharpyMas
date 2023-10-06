using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip035_RestrccionesClasesGenericas
{
    // base-class, T debe ser una subclase de una clase en particular
    // where T: clase-base
    // where T: clase
    // where T: interfaz
    // where T: struct
    // where T: new
    class CGenerica<T> where T: new() //Iinterfaz //CC //CB //CA
    {
        T objeto;
        public CGenerica(T pObjeto) 
        { 
            objeto = pObjeto;
        }

        public void Repetir() 
        {
            int n = 0;
            for(n=0;n<5;n++)
                Console.WriteLine(objeto);
        }
    }
}
