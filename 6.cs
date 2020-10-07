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
            int a, b7 = 0, i = 0;
            double zbir = 0;
            Console.WriteLine("Unesi brojeve: ");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a == 7)
                {
                    b7++;
                }
                else
                {
                    b7 = 0;
                }
                zbir += a;
                i++;
            } while (b7 != 2);
            Console.WriteLine("Srednja vrednost je {0}",zbir/i);
            Console.ReadKey();
        }
    }
}
