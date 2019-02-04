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
            Console.Write("Unit: ");
            var a = Console.ReadLine();

            Console.Write("Value: ");
            var b = double.Parse(Console.ReadLine());

            switch (a) {
                case "miles":
                    Console.WriteLine("{0:f2} km", b * 1.6);
                    break;

                case "inches":
                    Console.WriteLine("{0:f2} cm", b * 2.54);
                    break;

                case "feet":
                    Console.WriteLine("{0:f2} cm", b * 30);
                    break;

                case "yards":
                    Console.WriteLine("{0:f2} m", b * 0.91);
                    break;

                case "gallons":
                    Console.WriteLine("{0:f2} l", b * 3.8);
                    break;

                default:
                    Console.WriteLine("You didn't enter a valid unit!");
                    break;
            }
        }
    }
}
