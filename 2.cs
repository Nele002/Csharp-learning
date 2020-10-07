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
            int n;
            float a, sum = 0, avg;
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a = float.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine("Avg = {0}",sum/n);
            Console.ReadKey();
        }
    }
}
