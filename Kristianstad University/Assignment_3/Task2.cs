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
    class Task2
    {
        public void display()
        {
            input();
        }

        private void input()
        {
            WriteTextCentered("Account Book", ConsoleColor.Cyan);
            Console.WriteLine();

            Console.Write("Please enter your name: ");
            Account acc = new Account(Console.ReadLine(), 500);
            Console.Clear();
            
            WriteTextCentered(DateTime.Now.ToShortDateString(), ConsoleColor.DarkGray);
            WriteTextCentered(string.Format("Hello {0}, Welcome to the Account Book", acc.Name), ConsoleColor.Green);
            WriteTextCentered(string.Format("Balance: {0:C}", acc.Balance), ConsoleColor.Green);
            WriteTextCentered("=================================================");
            Console.WriteLine();

            Console.Write("Enter the deposit amount: ");
            double.TryParse(Console.ReadLine(), out double deposit);
            Console.WriteLine("Your balance becomes {0:C}", acc.Deposit(deposit));

            Console.Write("Enter the withdraw amount: ");
            double.TryParse(Console.ReadLine(), out double withdraw);
            if (acc.TryWithdraw(withdraw) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough money!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Your balance is {0:C}", acc.Balance);
            }
        }

        static void WriteTextCentered(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}