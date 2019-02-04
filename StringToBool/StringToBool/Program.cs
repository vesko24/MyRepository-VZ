using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            bool b = Convert.ToBoolean(a);

            if (b) Console.WriteLine("Yes");
                else { Console.WriteLine("No"); }
        }
    }
}
