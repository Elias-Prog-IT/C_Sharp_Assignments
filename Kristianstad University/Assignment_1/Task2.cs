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
    class Task2
    {
        private int num1;
        private string answer;

        public void taskTwoStart()
        {
            ReadAndSaveData();
            DisplayTask2Info();
        }

        public void ReadAndSaveData()
        {
            readIntegerOne();
        }

       public void readIntegerOne()
        {
            Console.Write("Type in a number, and we will check if it's an odd or even number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            doingNasaCalculation();
        }

        private void doingNasaCalculation()
        {
            if (num1 % 2 == 0)
            {
                answer = (" Which is an EVEN NUMBER!");
            }
            else
            {
                answer = (" Which is an ODD NUMBER!");
            }
        }

        public void DisplayTask2Info()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            string textOut = "You choose to check the number: " + num1 + " " + answer;
            Console.WriteLine(textOut);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
