using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList list = new DynamicList();

            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("Size= " + list.Count);

            list.Remove(0);

            Console.WriteLine("Size= " + list.Count);
        }
    }
}
