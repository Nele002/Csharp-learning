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
            int a, b, c;
            double avg;
            Console.WriteLine("Enter 3 numbers: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            avg = ((a + b + c) / 3.0);
            Console.WriteLine("Average = {0}",avg);
            Console.ReadKey();

        }
    }
}
