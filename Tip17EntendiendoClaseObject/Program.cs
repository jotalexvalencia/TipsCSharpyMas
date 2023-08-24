using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip17EntendiendoClaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona Juan = new CPersona("Juan", 27);

            // Vemos el comportamiento de ToString
            Console.WriteLine("--- ToString ---");
            Console.WriteLine(Juan.ToString());

            // Vemos el compotamiento de GetType
            Console.WriteLine("--- GetType ---");
            Console.WriteLine(Juan.GetType());
            Console.WriteLine(Juan.GetType().BaseType);

            CPersona Maria = new CPersona("Maria", 20);

            // Vemos el comportamiento de equals
            Console.WriteLine("--- Equals ---");
            if (Juan.Equals(Maria))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            CPersona Juan2 = new CPersona("Juan", 27);

            if(Juan.Equals(Juan2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            if(object.Equals(Juan, Juan2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            Object Maria2 = Maria;

            if(Maria.Equals(Maria2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            // Vemos como trabaja ReferenceEquals

            Console.WriteLine("--- ReferenceEquals ---");

            if(Object.ReferenceEquals(Maria,Maria2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            if(!Object.ReferenceEquals(Juan,Juan2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            // Vemos el comportamiento de GetHashCode
            Console.WriteLine("--- GetHashCode ---");
            Console.WriteLine(Juan.GetHashCode());
        }
    }
}
