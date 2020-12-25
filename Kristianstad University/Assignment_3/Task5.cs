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
    class Task5
    {
        public void display()
        {
            input();
        }
        //tar in värden
        private void input()
        {
            task5Console.WriteLine("Heart Rate Calculator", ConsoleColor.Cyan, task5Console.Alignment.Center);
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("LastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Birth Year: ");
            int.TryParse(Console.ReadLine(), out int birthYear);
            Console.Write("Current Year: ");
            int.TryParse(Console.ReadLine(), out int currentYear);

            outPut(name, lastName, birthYear, currentYear);
        }
        //skriver ut värden
        private void outPut(string name, string lastName, int birthYear, int currentYear)
        {
            HeartRates heartRate = new HeartRates(name, lastName, birthYear, currentYear);
            task5Console.WriteLine("============= SUMMARY =============", ConsoleColor.Cyan, task5Console.Alignment.Center);
            Console.Write("Name: ");
            task5Console.WriteLine(heartRate.FirstName, ConsoleColor.Green);
            Console.Write("LastName: ");
            task5Console.WriteLine(heartRate.LastName, ConsoleColor.Green);
            Console.Write("Birth Year: ");
            task5Console.WriteLine(heartRate.YearBirth.ToString(), ConsoleColor.Green);
            Console.Write("Age: ");
            task5Console.WriteLine(heartRate.Age().ToString(), ConsoleColor.Green);
            Console.Write("Maximum Heart Rate: ");
            task5Console.WriteLine(heartRate.MaximumHeartRate().ToString(), ConsoleColor.Magenta);
            Console.Write("Minimum Target Heart Rate: ");
            task5Console.WriteLine(heartRate.MinimumTargetHeartRate().ToString(), ConsoleColor.Yellow);
            Console.Write("Maximum Target Heart Rate: ");
            task5Console.WriteLine(heartRate.MaximumTargetHeartRate().ToString(), ConsoleColor.Yellow);
            Console.ReadLine();
        }
    }
}
