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
            string[] a = Console.ReadLine().Split();

            while (a[0] != "Close") {
                switch (a[0]) {
                    case "Add":
                        Maintenance.Add(a[1], a[2], double.Parse(a[3]), double.Parse(a[4]));
                        break;

                    case "Update":
                        Maintenance.Update(a[1], double.Parse(a[2]));
                        break;

                    case "Sell":
                        Maintenance.Sell(a[1], double.Parse(a[2]));
                        break;

                    case "PrintA":
                        Maintenance.PrintA();
                        break;

                    case "PrintU":
                        Maintenance.PrintU();
                        break;

                    case "PrintD":
                        Maintenance.PrintD();
                        break;

                    case "Calculate":
                        System.Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Maintenance.Calculate());
                        System.Console.ResetColor();
                        break;
                }

                a = Console.ReadLine().Split();
            }
        }
    }
}
