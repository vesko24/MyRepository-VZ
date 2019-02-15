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
            int[] b;
            int min;

            for (int i = 0; i < n; i++) {
                b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++) {
                    a[i, j] = b[j];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int j = 0; j < m; j++) {
                min = int.MaxValue;

                for (int i = 0; i < n; i++) {
                    if (a[i, j] < min) min = a[i, j];
                }

                Console.Write(min + " ");
            }

            Console.WriteLine();
        }
    }
}
