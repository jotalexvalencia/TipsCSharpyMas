using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip030ClasesyMetodosParciales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos y metodos parciales
            CEjemplo prueba = new CEjemplo();

            prueba.Costo = 500;

            Console.WriteLine(prueba);

            var orderStatsTuple = CalculateOrderStats();
            Console.WriteLine($@"Total Items: {orderStatsTuple.TotalItems} 
            Total Price: {orderStatsTuple.TotalPrice}
            Average Price per Item: {orderStatsTuple.AvgPricePerItem}");
        }

        static (int TotalItems , double TotalPrice, double AvgPricePerItem) CalculateOrderStats()
        {
            int totalItems = 10;
            double totalPrice = 250.00;
            double avgPricePerItem = totalPrice / totalItems;

            return(totalItems, totalPrice, avgPricePerItem);
        }
    }
}
