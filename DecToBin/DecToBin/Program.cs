﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal number: ");
            var n = int.Parse(Console.ReadLine());

            long k = 1, s = 0;

            while (n > 0) {
                s += (n % 2) * k;
                k *= 10;
                n /= 2;
            }

            Console.WriteLine("Binary number: " + s);
        }
    }
}
