using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CCompu compu1 = new CCompu();
            CCompu compu2 = new CCompu("i5", 4, 450);
            CCompu compu3 = new CCompu("i7", 8, 670);

            compu1.TipoCambio = 15.70; // con esto asignamos tipo de cambio 15.70 a comu2 y compu3

            // Mostramos
            compu1.MuestraDolares();
            compu1.MuestraPesos();
            Console.WriteLine("-----");

            compu2.MuestraDolares();
            compu2.MuestraPesos();
            Console.WriteLine("-----");

            compu3.MuestraDolares();
            compu3.MuestraPesos();
            Console.WriteLine("-----");

            Console.WriteLine("================================");

            // Hacemos el cambio, debe reflejarse en todos

            compu1.TipoCambio = 18.80;
            // Mostramos
            compu1.MuestraDolares();
            compu1.MuestraPesos();
            Console.WriteLine("-----");

            compu2.MuestraDolares();
            compu2.MuestraPesos();
            Console.WriteLine("-----");

            compu3.MuestraDolares();
            compu3.MuestraPesos();
            Console.WriteLine("-----");
        }
    }
}
