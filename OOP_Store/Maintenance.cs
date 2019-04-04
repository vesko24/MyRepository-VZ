using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class Maintenance
    {
        private static Product newProduct;
        private static Product pom;
        private static List<Product> Products = new List<Product>();
        private static List<Product> productsCopy = new List<Product>();
        private static double totalPrice = 0;

        public static void Add(string barcode, string name, double price, double quantity) {
            newProduct = new Product(barcode, name, price, quantity);
            Products.Add(newProduct);
        }

        public static void Update(string barcode, double quantity) {
            for (int i = 0; i < Products.Count(); i++) {
                if (barcode.Equals(Products[i].getBarcode())) {
                    Products[i].addQuantity(quantity);
                    break;
                } else { Console.WriteLine("Please add your product first!"); }
            }
        }

        public static void Sell(string barcode, double quantity) {
            for (int i = 0; i < Products.Count(); i++) {
                if (barcode.Equals(Products[i].getBarcode()) && quantity <= Products[i].getQuantity()) {
                    Products[i].removeQuantity(quantity);
                    break;
                } else { Console.WriteLine("Not enough quantity!"); }
            }
        }

        public static void PrintA() {
            productsCopy = Products;

            for (int i = 0; i < Products.Count() - 1; i++) {
                for (int j = 0; j < Products.Count() - i - 1; j++) {
                    if (Products[j].getName().CompareTo(Products[j + 1].getName()) > 0) {
                        pom = Products[j];
                        Products[j] = Products[j + 1];
                        Products[j + 1] = pom;
                    }
                }
            }

            for (int i = 0; i < Products.Count(); i++) {
                if (Products[i].getQuantity() > 0) {
                    Products[i].print();
                }
            }

            Products = productsCopy;
        }

        public static void PrintU() {
            productsCopy = Products;

            for (int i = 0; i < Products.Count() - 1; i++) {
                for (int j = 0; j < Products.Count() - i - 1; j++) {
                    if (Products[j].getName().CompareTo(Products[j + 1].getName()) > 0) {
                        pom = Products[j];
                        Products[j] = Products[j + 1];
                        Products[j + 1] = pom;
                    }
                }
            }

            for (int i = 0; i < Products.Count(); i++) {
                if (Products[i].getQuantity() == 0) {
                    Products[i].print();
                }
            }

            Products = productsCopy;
        }

        public static void PrintD() {
            productsCopy = Products;

            for (int i = 0; i < Products.Count() - 1; i++) {
                for (int j = 0; j < Products.Count() - i - 1; j++) {
                    if (Products[j].getQuantity() < Products[j + 1].getQuantity()) {
                        pom = Products[j];
                        Products[j] = Products[j + 1];
                        Products[j + 1] = pom;
                    }
                }
            }

            for (int i = 0; i < Products.Count(); i++) {
                Products[i].print();
            }

            Products = productsCopy;
        }

        public static double Calculate() {
            for (int i = 0; i < Products.Count(); i++) {
                totalPrice += Products[i].getQuantity() * Products[i].getPrice();
            }

            return totalPrice;
        }
    }
}
