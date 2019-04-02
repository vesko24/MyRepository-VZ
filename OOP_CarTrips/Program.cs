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

            string model;
            int distance;
            double fuel, fuel_1km;

            Car[] Cars = new Car[n];

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split();

                model = input[0];
                fuel = double.Parse(input[1]);
                fuel_1km = double.Parse(input[2]);

                Cars[i] = new Car(model, fuel, fuel_1km);
            }

            string[] input1 = Console.ReadLine().Split();
            distance = int.Parse(input1[2]);

            while (!input1[0].Equals("End")) {
                for (int i = 0; i < n; i++) {
                    if (input1[1].Equals(Cars[i].getModel())) {
                        Cars[i].trip(distance);
                        break;
                    }
                }

                input1 = Console.ReadLine().Split();
                if (input1.Length != 1) {
                    distance = int.Parse(input1[2]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                Cars[i].print();
            }

            Console.WriteLine();
        }
    }
}
