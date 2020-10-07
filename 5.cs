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
            int a, b7 = 0, zbir = 0;
            Console.WriteLine("Enter numbers: ");
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a == 7)
                {
                    b7++;
                }
                zbir += a;
            } while (b7 != 2);
            Console.WriteLine("Zbir je {0}", zbir);
            Console.ReadKey();
          

        }
    }
}
