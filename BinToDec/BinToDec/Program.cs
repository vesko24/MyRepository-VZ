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
            Console.Write("Binary number: ");
            var n = int.Parse(Console.ReadLine());

            double k, p = 0, s = 0;

            while (n > 0) {
                k = Math.Pow(2, p);
                s += (n % 10) * k;
                p += 1;
                n /= 10;
            }

            Console.WriteLine("Decimal number: " + s);
        }
    }
}
