using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of people: ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Elevator capacity: ");
            var p = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} courses", Math.Ceiling((double)n / p));
        }
    }
}
