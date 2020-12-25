/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-29
	Assignment_3, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModule3
{
    class Task3
    {
        public void display()
        {
            input();
        }

        private void input()
        {
            Task3Console.WriteLine("Account Book", ConsoleColor.Cyan, Task3Console.Alignment.Center);

            Console.Write("Please, enter your name: ");
            Account acc = new Account(Console.ReadLine(), 0);
            Console.Clear();

            Task3Console.WriteLine(DateTime.Now.ToShortDateString(), ConsoleColor.DarkGray, Task3Console.Alignment.Center);
            Task3Console.WriteLine(string.Format("Hello {0}, Welcome to the Account Book", acc.Name),
            ConsoleColor.Green, Task3Console.Alignment.Center);

            Task3Console.WriteLine(string.Format("Balance: {0:C}", acc.Balance), ConsoleColor.Green,
            Task3Console.Alignment.Center);
            Task3Console.WriteLine("=================================================", ConsoleColor.White,
            Task3Console.Alignment.Center);
            Console.WriteLine();

            do
            {
                PrintMenu(acc);
                Console.WriteLine();
                Console.Write("Please enter an option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        DepositMoney(acc);
                        break;
                    case "2":
                        Console.Clear();
                        WithdrawMoney(acc);
                        break;
                    case "3":
                        Task3Console.WriteLine("Bye bye", ConsoleColor.Yellow);
                        return;
                    default:
                        Task3Console.WriteLine("Invalid option", ConsoleColor.Red);
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }
            while (true);
        }

        //tar ut pengar från kontot
        private static void WithdrawMoney(Account acc)
        {
            Console.Write("Please, enter the amount to withdraw: ");
            double.TryParse(Console.ReadLine(), out double withdraw);
            if (acc.TryWithdraw(withdraw))
            {
                Console.WriteLine("Your balance becomes {0:C}", acc.Balance);
            }
            else
            {
                Task3Console.WriteLine("You don't have enough money", ConsoleColor.Red);
            }
            Console.ReadLine();
        }

        //sätter in pengar till kontot
        private static void DepositMoney(Account acc)
        {
            Console.Write("Please, enter the amount to deposit: ");
            if (double.TryParse(Console.ReadLine(), out double deposit))
            {
                Console.WriteLine("Your balance becomes {0:C}", acc.Deposit(deposit));
            }
            else
            {
                Task3Console.WriteLine("Invalid deposit", ConsoleColor.Red);
            }
            Console.ReadLine();
        }
       
        //skriver ut menyn
        static void PrintMenu(Account acc)
        {
            Console.WriteLine("Your balance is {0:C}", acc.Balance);
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Exit");
        }

    }
}
