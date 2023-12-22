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
            //CPersona per1 = new CPersona();

            //CPersona per2 = new CPersona("Juan", 27);

            //per1.muestra();
            //per2.muestra();

            //List<string> fruits = new List<string> { "apple", "banana", "berry", "cherry" };
            //var average = numbers.Average();
            //var result = fruits.OrderBy(f=>f.Length).ThenBy(f=>f).ToList();


            //foreach (var fruit in result)
            //{
            //    Console.WriteLine(fruit);
            //}

            //var m = new Dictionary<object, int>();
            //var o1 = new object();
            //var o2 = o1;
            //m[o1] = 1;
            //m[o2] = 2;

            //Console.WriteLine($"{m[o1]}");

            Console.Write("Enter a positive integer (greater than or equal to 2): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n >= 2)
            {
                Console.Write("Prime factors of " + n + ": ");
                CalculateAndDisplayPrimeFactors(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer greater than or equal to 2.");
            }

            bool ShopOpen = IsShopOpen("monday");
            Console.WriteLine(ShopOpen);
        }

        static void CalculateAndDisplayPrimeFactors(int n)
        {
            for (int divisor = 2; n > 1; divisor++)
            {
                while (n % divisor == 0)
                {
                    Console.Write(divisor + " ");
                    n /= divisor;
                }
            }
        }

        static bool IsShopOpen(string day)
        {
            if (string.IsNullOrEmpty(day))
                return false;

            var openingDays = new[] { "friday", "saturday", "sunday" };
            return openingDays.Any(d=> d == day.ToLower());
        }

    }
}
