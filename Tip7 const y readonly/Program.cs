using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip7_const_y_readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que muestra el uso de constantes

            // variables
            // const se debe asignar cuando estoy programando
            const double impuesto = 0.16;
            double valor = 5000.0;
            double impuestoPagar = 0.0;
            double costoFinal = 0.0;

            string dato = "";
            double costoextra = 0.0;

            impuestoPagar = valor * impuesto;
            costoFinal = valor + impuestoPagar;
            //impuesto = 0.20; no se puede ya que es declarada como constante

            Console.WriteLine("El total es {0}", costoFinal);

            // Ahora mostramos el uso de readonly

            Console.WriteLine("Dame el valor del costo extra");
            dato = Console.ReadLine();
            costoextra=Convert.ToDouble(dato);

            miEjemplo objeto = new miEjemplo(costoextra);

            costoFinal += objeto.CostoExtra;

            Console.WriteLine("El gran total es {0}", costoFinal);



        }
    }

    class miEjemplo
    {
        // readonly permite asignar el valor en tiempo de ejecución
        private readonly double costoextra; // tiene que ser asignado dentro del constructor

        public miEjemplo(double pExtra)
        {
            // Asignamos al readonly, y a partir de aca nada pueda cambiar su valor
            costoextra = pExtra;
        }

        public double CostoExtra
        {
            get { return costoextra; }
           
        }
    }
    
}
