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
            Console.Write("Type: ");
            var a = Console.ReadLine();

            switch (a) {
                case "int":
                        Console.WriteLine("Max value: " + int.MaxValue);
                        Console.WriteLine("Min value: " + int.MinValue);
                        break;

                case "uint":
                        Console.WriteLine("Max value: " + uint.MaxValue);
                        Console.WriteLine("Min value: " + uint.MinValue);
                        break;

                case "long":
                        Console.WriteLine("Max value: " + long.MaxValue);
                        Console.WriteLine("Min value: " + long.MinValue);
                        break;

                case "byte":
                        Console.WriteLine("Max value: " + byte.MaxValue);
                        Console.WriteLine("Min value: " + byte.MinValue);
                        break;

                case "sbyte":
                        Console.WriteLine("Max value: " + sbyte.MaxValue);
                        Console.WriteLine("Min value: " + sbyte.MinValue);
                        break;

                default: 
                    Console.WriteLine("You didn't enter a valid type!");
                    break;
            }
        }
    }
}
