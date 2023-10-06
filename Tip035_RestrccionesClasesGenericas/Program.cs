using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip035_RestrccionesClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restricciones genericas

            CA objetoA = new CA();
            CB objetoB = new CB();
            CC objetoC = new CC();

            CGenerica<CA> oGen = new CGenerica<CA>(objetoA);

            oGen.Repetir();
        }
    }
}
