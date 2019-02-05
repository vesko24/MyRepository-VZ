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

            if (a.Length == 1) Console.WriteLine("{{ {0} }}", a[0]);
            if (a.Length % 2 == 0) Console.WriteLine("{{ {0}, {1} }}", a[a.Length / 2 - 1], a[a.Length / 2]);
            if (a.Length % 2 != 0 && a.Length != 1) Console.WriteLine("{{ {0}, {1}, {2} }}", a[a.Length / 2 - 1], a[a.Length / 2], a[a.Length / 2 + 1]);
        }
    }
}
