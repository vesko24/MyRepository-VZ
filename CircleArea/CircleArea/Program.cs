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
            Console.Write("r= ");
            var r = double.Parse(Console.ReadLine());

            Console.WriteLine("Circle's area: {0:f12}", Math.PI * r * r);
        }
    }
}
