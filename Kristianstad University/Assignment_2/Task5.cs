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
    class Task5
    {
        private const int minTemp = -30;
        private const int maxTemp = 50;
        public void displayTask5()
        {
            celciusToFarenheit();
        }

        private void celciusToFarenheit()
        {
            Console.WriteLine("{0,-10}{1,-10}", "Celsius", "Fahrenheit");
            for (int i = minTemp; i <= maxTemp; i += 5)
            {
                Console.WriteLine("{0,-10}{1,-10}", i, celsiusCalculator(i));
            }
        }

        private static double celsiusCalculator(double value)
        {
            return value * (9.0 / 5.0) + 32;
        }
    }
}