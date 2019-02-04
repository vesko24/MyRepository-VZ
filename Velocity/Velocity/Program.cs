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
            Console.Write("Metres: ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("Hours: ");
            var b = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            var c = int.Parse(Console.ReadLine());

            Console.Write("Seconds: ");
            var d = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:f6} m/s", a / (b * 3600 + c * 60 + d));
            Console.WriteLine("{0:f6} km/h", a / 1000 / (b + (double)c / 60 + (double)d / 3600));
            Console.WriteLine("{0:f6} mp/h", a / 1609 / (b + (double)c / 60 + (double)d / 3600));
        }
    }
}
