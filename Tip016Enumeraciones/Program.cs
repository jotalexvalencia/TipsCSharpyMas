using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip016Enumeraciones
{
    class Program
    {
        public enum tipoImagen { BMP, JPG, PNG, GIF, TIFF};
                                                        
        static void Main(string[] args)
        {
            string dato = "";
            double tamanoImg = 0.0;

            Console.WriteLine("Dame el tamaño de la imagen");
            dato = Console.ReadLine();
            tamanoImg = Convert.ToDouble(dato);

            calcularEspacio(tipoImagen.PNG, tamanoImg);
        }

        // 0-BMP, 1-JPG, 2-PNG, 3-GIF, 4-TIFF
        public static void calcularEspacio(tipoImagen pImagen, double tamano)
        {
            double espacio = 0;

            switch (pImagen)
            {
                case tipoImagen.BMP:
                    espacio = tamano * 1.1;
                    break; 
                case tipoImagen.JPG:
                    espacio = tamano * 0.8;
                    break;
                case tipoImagen.PNG:
                    espacio = tamano * 0.77;
                    break;
                case tipoImagen.GIF:
                    espacio = tamano * 1.5;
                    break;
                case tipoImagen.TIFF:
                    espacio = tamano * 0.97;
                    break;
            }

            Console.WriteLine("El tamaño final es {0}", espacio);

        }
    }
}
