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
            Console.Write("n= ");
            var n = int.Parse(Console.ReadLine());

            Console.Write("m= ");
            var m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            double b;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++) {
                b = 0;

                for (int j = 0; j < m; j++) {
                    Console.Write(a[i, j] + " ");
                    b += a[i, j];
                }

                Console.Write(b / m);
                Console.WriteLine();
            }
        }
    }
}
