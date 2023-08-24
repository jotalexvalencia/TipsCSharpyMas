using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip18OverrideClaeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona Juan = new CPersona("Juan",27);

            // ToString que ya se hizo override
            Console.WriteLine("--- ToString ---");
            Console.WriteLine(Juan.ToString());

            // Equals ya se hizo override
            CPersona Maria = new CPersona("Maria", 20);
            Console.WriteLine("--- Equals ---");
            if (Juan.Equals(Maria))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            CPersona Juan2 = new CPersona("Juan", 27);
            if (Juan.Equals(Juan2))
                Console.WriteLine("iguales");
            else
                Console.WriteLine("diferentes");

            // GetHashCode ya se hizo override
            Console.WriteLine("--- GetHashCode ---");
            Console.WriteLine(Juan.GetHashCode());
        }
    }
}
