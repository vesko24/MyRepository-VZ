using System;
using System.Collections.Generic;
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
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue, max = int.MinValue, s = 0, br = 0;

            for (int i = 0; i < a.Length; i++) {
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
                s += a[i];
                br++;
            }

            Console.WriteLine("Min= " + min);
            Console.WriteLine("Max= " + max);
            Console.WriteLine("Sum= " + s);
            Console.WriteLine("Average: {0:f2}", (double)s / br);
        }
    }
}