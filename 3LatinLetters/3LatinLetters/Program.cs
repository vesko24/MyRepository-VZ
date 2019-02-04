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
            Console.Write("n= ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    for (int k = 0; k < n; k++) {
                        Console.Write((char)('a' + i));
                        Console.Write((char)('a' + j));
                        Console.WriteLine((char)('a' + k));
                    }
                }
            }
        }
    }
}
