using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 25, 16, -9, 182, 53, 40, -18, 2, 84, 149 };

            Console.WriteLine("Selection Sort:");
            Console.WriteLine();
            Console.WriteLine("Initial Array:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted Array:");

            SelectionSort.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

