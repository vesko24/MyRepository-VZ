using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Product
    {
        protected string name;
        protected string barcode;
        protected double price;
        protected double quantity;

        public Product(string barcode, string name, double price, double quantity) {
            this.name = name;
            this.barcode = barcode;
            this.price = price;
            this.quantity = quantity;
        }

        public void addQuantity(double quantity) {
            this.quantity += quantity;
        }

        public void removeQuantity(double quantity) {
            this.quantity -= quantity;
        }

        public string getName() {
            return name;
        }

        public string getBarcode() {
            return barcode;
        }

        public double getPrice() {
            return price;
        }

        public double getQuantity() {
            return quantity;
        }

        public void print() {
            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} ({1})", getName(), getBarcode());
            System.Console.ResetColor();
        }
    }
}
