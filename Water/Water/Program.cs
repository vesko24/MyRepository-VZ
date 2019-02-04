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

            int a, s = 0, br = 0;

            for (int i = 0; i < n; i++) {
                a = int.Parse(Console.ReadLine());
                
                s += a;

                if (s > 255) {
                    s -= a;
                    br++;
                }
            }

            for (int i = 0; i < br; i++) Console.WriteLine("Insufficient capacity!");
            Console.WriteLine(s);
        }
    }
}
