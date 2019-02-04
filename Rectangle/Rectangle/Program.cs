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
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("b= ");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("P= " + (2 * a + 2 * b));
            Console.WriteLine("S= " + (a * b));
            Console.WriteLine("d= {0:f2}", Math.Sqrt(a * a + b * b));
        }
    }
}
