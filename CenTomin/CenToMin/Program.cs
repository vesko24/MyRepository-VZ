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
            Console.Write("Centuries: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Years: " + n * 100);
            Console.WriteLine("Days: " + n * 100 * 365);
            Console.WriteLine("Hours: " + n * 100 * 365 * 24);
            Console.WriteLine("Minutes: " + n * 100 * 365 * 24 * 60);
        }
    }
}
