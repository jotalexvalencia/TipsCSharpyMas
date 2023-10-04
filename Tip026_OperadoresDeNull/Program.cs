using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip026_OperadoresDeNull
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de null

            // Operador coalescente(incorporacion)
            // Funciona con nuestras clases y tipos nulleables
            // Si el operando no es null, se asigna
            // si no se da el valor de default
            // r= op ?? default

            string a = null;
            string b = "hola";
            string r;

            r = a ?? "fue un null";
            Console.WriteLine(r);

            r = b ?? "fue un null";
            Console.WriteLine(r);

            Console.WriteLine("---------");

            // Operador Null-condicional
            // También se le llama Elvis ?.
            // Permite invocar métodos y acceder como lo hace el operador .
            // La ventaja que nos da es que si el operando es null, la expresión evalua a null
            // y no lanza un NullReferenceException

            // Este codigo genera excepcion
            //string rs = a.ToString();

            // Este no genera excepcion
            string rs = a?.ToString();
            Console.WriteLine(rs);

            // Para que funcione, la expresión debe aceptar un null

            //int cantidad = a?.ToString().Length;
            int? cantidadN = a?.ToString().Length;

            Console.WriteLine(cantidadN);

        }
    }
}
