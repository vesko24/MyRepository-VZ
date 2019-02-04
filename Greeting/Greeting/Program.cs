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
            Console.Write("First name: ");
            var a = Console.ReadLine();

            Console.Write("Last name: ");
            var b = Console.ReadLine();

            Console.Write("Age: ");
            var c = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0} {1}. You are {2} years old.", a, b, c);
        }
    }
}
