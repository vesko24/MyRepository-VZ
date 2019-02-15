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
            Console.Write("n, m = ");
            int[] a = new int[2];
            a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] b = new int[a[0], a[1]];
            int[] c;
            int s = 0, s1 = 0, s2 = 0, s3 = 0, s4 = 0;
            int k;
            bool win = false;

            for (int i = 0; i < a[0]; i++)
            {
                c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < a[1]; j++)
                {
                    b[i, j] = c[j];
                }
            }

            for (int i = 0; i < a[0]; i++)
            {
                for (int j = 0; j < a[1]; j++)
                {
                    if (i == j)
                    {
                        s1 += b[i, j];
                        if (b[i, j] % 2 == 0) s += b[i, j];
                    }
                }
            }

            for (int i = a[0] - 1; i >= 0; i--)
            {
                for (int j = a[1] - 1; j >= 0; j--)
                {
                    if (i == j) s2 += b[i, j];
                }
            }

            k = 0;

            for (int j = 0; j < a[1] - 1; j++)
            {
                for (int i = 1 + k; i < a[0]; i++)
                {
                    s3 += b[i, j];
                }

                k++;
            }

            s += s3;
            k = 0;

            for (int j = a[1] - 1; j > 0; j--)
            {
                for (int i = a[0] - 2 - k; i >= 0; i--)
                {
                    s4 += b[i, j];
                }

                k++;
            }

            for (int i = 0; i < a[0]; i++)
            {
                for (int j = 0; j < a[1]; j++)
                {
                    if (i == 0 || i == a[0] - 1)
                    {
                        if (b[i, j] % 2 == 0) s += b[i, j];
                    }
                }
            }

            for (int j = 0; j < a[1]; j++)
            {
                for (int i = 0; i < a[0]; i++)
                {
                    if (j == 0 || j == a[1] - 1)
                    {
                        if (b[i, j] % 2 != 0) s += b[i, j];
                    }
                }
            }

            if (s1 == s2) win = true;
            if (s3 % 2 != 0) win = true;
            if (s4 % 2 == 0) win = true;

            if (win == true)
            {
                Console.WriteLine("YES");
                Console.WriteLine("The amount of money you won is: {0:f2}", (double)s / 4);
            }
            else { Console.WriteLine("NO"); }

        }
    }
}
