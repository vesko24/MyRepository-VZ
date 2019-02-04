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

            int a, s;

            for (int i = 1; i <= n; i++) {
                s = 0;
                a = i;

                while (a != 0) {
                    s += a % 10;
                    a /= 10;
                }

                if (s == 5 || s == 7 || s == 11) Console.WriteLine("{0} -> True", i);
                    else { Console.WriteLine("{0} -> False", i); }
            }
        }
    }
}
