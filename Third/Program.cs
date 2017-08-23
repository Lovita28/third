using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPING
            // 1. check if prime
            /*Console.Write("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);
            */

            //Factorial
            /*int n = int.Parse(Console.ReadLine());
            // "decimal" is the biggest C# type that can hold integer values
            decimal factorial = 1;
            // Perform an "infinite loop"
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);*/

            //product in range
            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;
            do
            {
                product *= num;
                num++;
            } while (num <= m);
            Console.WriteLine("product[n...m] = " + product);
            */

            //n^m
            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);
            */

            //larger and smaller
            /*for (int small = 1, large = 10; small < large; small++, large--)
            {
                Console.WriteLine(small + " " + large);
            }
            */
            //foreach
            /*int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)
            {
                Console.Write(" " + town);
            }
            */

            //triangle
            /*int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }*/
            //Prime range
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write(" " + num);
                }
            }


            Console.ReadKey();
        }
    }
}
