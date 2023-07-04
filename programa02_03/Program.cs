using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona per1 = new CPersona();

            CPersona per2 = new CPersona("Juan", 27);

            per1.muestra();
            per2.muestra();
        }
    }
}
