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
            List<int> a = new List<int>();
            string b;
            int c = 0, s = 0;

            b = Console.ReadLine();

            a = b.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < a.Count; i++) {
                c = 0;

                while (a[i] != 0) {
                    c = c * 10 + a[i] % 10;
                    a[i] /= 10;
                }

                s += c;
            }

            Console.WriteLine(s);
        }
    }
}
