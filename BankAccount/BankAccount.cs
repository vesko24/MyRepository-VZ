using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class BankAccount
    {
        private int ID;
        private double balance;

        public void setID(int ID) {
            this.ID = ID;
        }

        public void setBalance(double balance) {
            this.balance = balance;
        }

        public void deposit(double amount) {
            balance += amount;
        }

        public void withdraw(double amount) {
            balance -= amount;
        }

        public int getID() {
            return ID;
        }

        public double getBalance() {
            return balance;
        }

        public void print() {
            Console.WriteLine();
            Console.WriteLine("Account ID: {0}", getID());
            Console.WriteLine("Balance: {0:f2}", getBalance());
            Console.WriteLine();
        }

        public void printMenu() {
            Console.WriteLine();
            Console.WriteLine("[1] Deposit");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Exit");
            Console.WriteLine();
        }
    }
}
