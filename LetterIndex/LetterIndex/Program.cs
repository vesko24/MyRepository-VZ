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
            Console.Write("Enter a word: ");
            var b = Console.ReadLine();

            for (int i = 0; i < b.Length; i++) {
                if (b[i] >= 'a' && b[i] <= 'z') {
                    Console.WriteLine("{0} -> {1}", b[i], (int)b[i] - 96);
                }
            }
        }
    }
}
