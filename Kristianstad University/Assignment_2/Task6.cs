/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-01
	Assignment_2, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Module2
{
    class Task6
    {
        public void displayTask6()
        {
            gradeHandler();
        }

        private void gradeHandler()
        {
            string grade = null;
            do
            {
                Console.Write("Exit by pressing 'G'" + 
                Environment.NewLine + "Please enter the grade: ");
                grade = Console.ReadLine();
                switch (grade)
                {
                    case "A":
                        Console.WriteLine("Excellent – outstanding performance with only minor errors");
                        break;
                    case "B":
                        Console.WriteLine("Very good – above the average standard but with some errors");
                        break;
                    case "C":
                        Console.WriteLine("Good– generally sound work with a number of notable errors");
                        break;
                    case "D":
                        Console.WriteLine("Satisfactory – fair but with significant shortcomings");
                        break;
                    case "E":
                        Console.WriteLine("Sufficient – performance meets the minimum criteria");
                        break;
                    case "Fx":
                        Console.WriteLine("Fail – some more work required before the credit can be awarded");
                        break;
                    case "F":
                        Console.WriteLine("Fail - considerable further work is required");
                        break;
                }
            }
            while (grade != "G");
        }

    }
}
