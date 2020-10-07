using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n, a;
            do
            {
                Console.WriteLine("Enter n:");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            for (int i = 0; i < n; i++)
            {
                a = rnd.Next(1, 100);
                // Test
                // Console.WriteLine("Random broj: {0}, index{1}",a,i+1);
                if (a % 2 == 0 && a > 20 && a < 40)
                {
                    continue;
                }
                else if (a % 2 != 0 && a > 70 && a < 90)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadKey();
        }
    }
}
