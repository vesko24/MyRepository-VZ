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
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];
            int[] d = new int[a.Length];
            int max = int.MinValue, br = 0, p = 0;

            Array.Copy(a, b, a.Length);

                for (int i = 0; i < a.Length; i++) {
                    for (int j = 0; j < a.Length; j++) {
                        if (a[i] == b[j]) {
                            br++;
                            p = a[i];
                        }
                    }
                    c[i] = br;
                    d[i] = p;
                    br = 0;
                }

                for (int i = 0; i < c.Length; i++) {
                    if (c[i] > max) {
                        max = c[i];
                        p = i;
                    }
                }

                Console.WriteLine(d[p]);
        }
    }
}
