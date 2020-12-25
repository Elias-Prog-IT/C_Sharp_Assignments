/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-09-20
	Assignment_1, Different Tasks Assignment
	Kristianstad University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Task7
    {

        private int numbers, square, cube;
        
        public void taskSevenStart()
        {
            ReadAndSaveData();
            DisplayTask7Info();
        }

        public void ReadAndSaveData()
        {
            ReadInput();
        }

        private void ReadInput()
        {
            Console.WriteLine("Please enter digits: ");
            numbers = Convert.ToInt32(Console.ReadLine());
            Calculate();
        }

        private void Calculate()
        {
            square = numbers * numbers;
            cube = numbers * numbers * numbers;
        }

        private void DisplayTask7Info()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Numbers: \t Square:\t Cube:\n" + "{0}\t\t{1}\t\t{2}",
            numbers,square,cube);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
