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
            BankAccount newAccount = new BankAccount();
            int a;
            double b;

            Console.Write("Enter ID: ");
            a = int.Parse(Console.ReadLine());
            newAccount.setID(a);

            Console.Write("Enter balance: ");
            b = double.Parse(Console.ReadLine());
            newAccount.setBalance(b);

            newAccount.printMenu();
            Console.Write("Input: ");
            a = int.Parse(Console.ReadLine());

            while (a != 3) {
                if (a == 1) {
                    Console.Write("Deposit amount: ");
                    b = double.Parse(Console.ReadLine());

                    newAccount.deposit(b);
                }

                if (a == 2) {
                    Console.Write("Withdraw amount: ");
                    b = double.Parse(Console.ReadLine());

                    while (b > newAccount.getBalance()) {
                        Console.Write("Enter new withdraw amount: ");
                        b = double.Parse(Console.ReadLine());
                    }

                    newAccount.withdraw(b);
                }

                newAccount.printMenu();
                Console.Write("Input: ");
                a = int.Parse(Console.ReadLine());
            }

            newAccount.print();
        }
    }
}
