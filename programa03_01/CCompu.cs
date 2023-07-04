using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa03_01
{
    class CCompu
    {
        private static double tipoCambio;

        private string procesador = "";
        private int memoria;
        private double costo;

        public CCompu()
        {
            procesador = "i3";
            memoria = 2;
            costo = 350;
        }
        public CCompu(string pProcesador, int pMemoria, double pCosto)
        {
            procesador = pProcesador;
            memoria = pMemoria;
            costo = pCosto;
            
        }
        public double TipoCambio
        {
            set{ tipoCambio = value; }
        }
        public void MuestraDolares()
        {
            Console.WriteLine("Procesador: {0}, memoria: {1}",procesador,memoria);
            Console.WriteLine("Costo $USD:{0}",costo);
        }
        public void MuestraPesos()
        {
            Console.WriteLine("Procesador: {0}, memoria: {1}", procesador, memoria);
            Console.WriteLine("Costo $:{0}, TC:{1}", costo*tipoCambio,tipoCambio);
        }
    }
}
