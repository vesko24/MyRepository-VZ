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

            b = Console.ReadLine();

            a = b.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < a.Count; i++) {
                if (a[i] == a[a.Count - 1]) a.Remove(a[i]);
            }

            a.RemoveAt(a.Count - 1);

            for (int i = 0; i < a.Count; i++) Console.Write(a[i] + " ");

            Console.WriteLine();
        }
    }
}
