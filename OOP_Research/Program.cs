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
            Console.Write("n= ");
            var n = int.Parse(Console.ReadLine());

            Person[] People = new Person[n];
            Person pom = new Person();
            string[] input;

            for (int i = 0; i < n; i++) {
                input = Console.ReadLine().Split();

                People[i] = new Person();
                People[i].setName(input[0]);
                People[i].setAge(int.Parse(input[1]));
            }

            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (People[j].getName().CompareTo(People[j + 1].getName()) > 0) {
                        pom = People[j];
                        People[j] = People[j + 1];
                        People[j + 1] = pom;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                if (People[i].getAge() > 30) {
                    People[i].print();
                }
            }

            Console.WriteLine();
        }
    }
}
