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
            Console.Write("Hexadecimal number: ");
            var n = Console.ReadLine();

            int a, b = 0;
            double s = 0;

            for (int i = n.Length-1; i >= 0; i--) {
                if (n[i] == '1') {
                    a = 1;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '2')
                {
                    a = 2;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '3')
                {
                    a = 3;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '4')
                {
                    a = 4;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '5')
                {
                    a = 5;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '6')
                {
                    a = 6;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '7')
                {
                    a = 7;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '8')
                {
                    a = 8;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == '9')
                {
                    a = 9;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'A')
                {
                    a = 10;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'B')
                {
                    a = 11;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'C')
                {
                    a = 12;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'D')
                {
                    a = 13;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'E')
                {
                    a = 14;
                    s += a * Math.Pow(16, b);
                }

                if (n[i] == 'F')
                {
                    a = 15;
                    s += a * Math.Pow(16, b);
                }

                b++;
            }

            Console.WriteLine("Decimal number: " + s);
        }
    }
}
