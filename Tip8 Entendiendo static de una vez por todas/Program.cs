using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip8_Entendiendo_static_de_una_vez_por_todas
{
    class Program
    {
        static void Main(string[] args)
        {
            // No puedo invocar un método sin instancia, marca error
            //MiClase.saluda();

            // De esta forma si funciona
            MiClase miObjeto = new MiClase();
            miObjeto.saluda();

            // Un método estatico si puede ser invocado sin instancia
            //MiClase.mensaje();
            //MiClase.imprimeValor();
            MiClase.imprimeNumero();
        }
    }
}
