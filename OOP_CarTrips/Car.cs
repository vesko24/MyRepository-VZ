using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Car
    {
        private string model;
        private int wholeDistance = 0;
        private double fuel, fuel_1km;

        public Car(string model, double fuel, double fuel_1km) {
            this.model = model;
            this.fuel = fuel;
            this.fuel_1km = fuel_1km;
        }

        public void setWholeDistance(int wholeDistance) {
            this.wholeDistance += wholeDistance;
        }

        public void removeFuel(double fuel) {
            this.fuel -= fuel;
        }

        public string getModel() {
            return model;
        }

        public double getFuel() {
            return fuel;
        }

        public double getFuel_1km() {
            return fuel_1km;
        }

        public int getWholeDistance() {
            return wholeDistance;
        }

        public void trip(int distance) {
            if (distance * getFuel_1km() <= getFuel()) {
                setWholeDistance(distance);
                removeFuel(distance * getFuel_1km());
            } else {
                Console.WriteLine();
                Console.WriteLine("Insufficient fuel for the drive!");
            }
        }

        public void print() {
            Console.WriteLine("{0} {1:f2} {2}", getModel(), getFuel(), getWholeDistance());
        }
    }
}
