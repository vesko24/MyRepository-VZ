using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Freight
    {
        private string name;
        private int weight;

        public Freight() { }

        public Freight(string name1, int weight1) {
            name = name1;
            weight = weight1;
        }

        public string getName() {
            return name;
        }

        public int getWeight() {
            return weight;
        }
    }
}
