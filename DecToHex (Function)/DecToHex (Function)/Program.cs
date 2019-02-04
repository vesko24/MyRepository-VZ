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
            Console.Write("Decimal number: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Hexadecimal number: " + Convert.ToString(n, 16).ToUpper());
        }
    }
}
