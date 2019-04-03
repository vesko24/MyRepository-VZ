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
            List<string> a = new List<string>();
            a = Console.ReadLine().Split(';').ToList();
            a.Remove("");

            List<string> b = new List<string>();
            b = Console.ReadLine().Split(';').ToList();
            b.Remove("");

            Truck[] Trucks = new Truck[a.Count()];
            Freight[] Freights = new Freight[b.Count()];
            List<string> c = new List<string>();
            List<string> d = new List<string>();
            string[] e;

            string f = "BigTruck - ";
            string g = "Truck - ";
            string h = "LittleTruck - ";

            for (int i = 0; i < a.Count(); i++) {
                Trucks[i] = new Truck(a[i].Substring(0, a[i].IndexOf('=')), int.Parse(a[i].Substring(a[i].IndexOf('=') + 1)));
            }

            for (int i = 0; i < b.Count(); i++) {
                Freights[i] = new Freight(b[i].Substring(0, b[i].IndexOf('=')), int.Parse(b[i].Substring(b[i].IndexOf('=') + 1)));
            }

            e = Console.ReadLine().Split();

            while (e[0] != "END") {

                if (e[0].Equals("BigTruck")) {
                    for (int i = 0; i < b.Count(); i++) {
                        if (e[1].Equals(Freights[i].getName()) && Trucks[0].getLoadability() >= Freights[i].getWeight()) {
                            Trucks[0].setLoadability(Freights[i].getWeight());
                            d.Add("BigTruck loaded " + Freights[i].getName());

                            if (f.Equals("BigTruck - ")) f += Freights[i].getName();
                            else { f += ", " + Freights[i].getName(); }

                            break;
                        }

                        if (e[1].Equals(Freights[i].getName()) && Trucks[0].getLoadability() < Freights[i].getWeight()) {
                            d.Add("BigTruck can not load " + Freights[i].getName());
                            break;
                        }
                    }
                }

                if (e[0].Equals("Truck")) {
                    for (int i = 0; i < b.Count(); i++) {
                        if (e[1].Equals(Freights[i].getName()) && Trucks[1].getLoadability() >= Freights[i].getWeight()) {
                            Trucks[1].setLoadability(Freights[i].getWeight());
                            d.Add("Truck loaded " + Freights[i].getName());

                            if (g.Equals("Truck - ")) g += Freights[i].getName();
                            else { g += ", " + Freights[i].getName(); }

                            break;
                        }

                        if (e[1].Equals(Freights[i].getName()) && Trucks[1].getLoadability() < Freights[i].getWeight()) {
                            d.Add("Truck can not load " + Freights[i].getName());
                            break;
                        }
                    }
                }

                if (e[0].Equals("LittleTruck")) {
                    for (int i = 0; i < b.Count(); i++) {
                        if (e[1].Equals(Freights[i].getName()) && Trucks[2].getLoadability() >= Freights[i].getWeight()) {
                            Trucks[2].setLoadability(Freights[i].getWeight());
                            d.Add("LittleTruck loaded " + Freights[i].getName());

                            if (h.Equals("LittleTruck - ")) h += Freights[i].getName();
                            else { h += ", " + Freights[i].getName(); }

                            break;
                        }

                        if (e[1].Equals(Freights[i].getName()) && Trucks[2].getLoadability() < Freights[i].getWeight()) {
                            d.Add("LittleTruck can not load " + Freights[i].getName());
                            break;
                        }
                    }
                }

                e = Console.ReadLine().Split();
            }

            Console.WriteLine();

            for (int i = 0; i < d.Count(); i++) {
                Console.WriteLine(d[i]);
            }

            Console.WriteLine();

            if (!f.Equals("BigTruck - ")) Console.WriteLine(f);
            else { Console.WriteLine("BigTruck - Nothing loaded"); }

            if (!g.Equals("Truck - ")) Console.WriteLine(g);
            else { Console.WriteLine("Truck - Nothing loaded"); }

            if (!h.Equals("LittleTruck - ")) Console.WriteLine(h);
            else { Console.WriteLine("LittleTruck - Nothing loaded"); }

            Console.WriteLine();
        }
    }
}
