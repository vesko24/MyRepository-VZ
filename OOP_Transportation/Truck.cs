using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Truck
    {
        private string truckName;
        private int loadability;

        public Truck(string truckName, int loadability) {
            this.truckName = truckName;
            this.loadability = loadability;
        }

        public void setLoadability(int loadability) {
            this.loadability -= loadability;
        }

        public string getTruckName() {
            return truckName;
        }

        public int getLoadability() {
            return loadability;
        }
    }
}
