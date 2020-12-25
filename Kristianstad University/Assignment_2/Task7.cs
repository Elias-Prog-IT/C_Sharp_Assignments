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
    class Task7
    {

        public void displayTask7()
        {
            input();
        }

        private void input()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You need to enter a set of numbers to calculate the smallest number and finish by entering the number 0 (zero).");
            Console.WriteLine();
            Console.ResetColor();
            int number = 0;
            List<int> numbers = new List<int>();
            do
            {
                Console.Write("Please enter a number: ");

                if (int.TryParse(Console.ReadLine(), out number) == false)
                {
                    return;
                }
                else
                {
                    if (number != 0)
                    {
                        numbers.Add(number);
                    } 
                }
            } while (number != 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The smallest number you have typed in is: {0}", CalculateSmallestNumber(numbers));
            Console.ResetColor();
        }

        private static int CalculateSmallestNumber(List<int> numbers)
        {
            int smallestNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < smallestNumber) smallestNumber = numbers[i];
            }
            return smallestNumber;
        }
    }
}
