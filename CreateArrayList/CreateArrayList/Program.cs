using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();

            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine("Size= " + list.Count);

            int t = list.RemoveAt(0);

            Console.WriteLine(list[0]);
            Console.WriteLine("Size= " + list.Count);
        }
    }
}
