using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_02
{
    class CCalculadora
    {
        private double a;
        private double b;
        private double r;

        public CCalculadora(double pa, double pb)
        {
            a = pa;
            b = pb;
            
        }

        public double R 
        {
            get { return r; } 
        }

        public void suma() 
        {
            r = a + b;
        }

        public void resta()
        {
            r = a - b;
        }
    }
}
