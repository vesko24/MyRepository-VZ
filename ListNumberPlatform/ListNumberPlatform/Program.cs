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
            int br = 1, k = 0, max = int.MinValue;

            b = Console.ReadLine();

            a = b.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < a.Count - 1; i++) {
                if (a[i] == a[i + 1]) br++;
                else { br = 1; }

                if (br > max) {
                    max = br;
                    k = a[i];
                }
            }

            for (int i = 0; i < max; i++) Console.Write(k + " ");

            Console.WriteLine();
        }
    }
}
