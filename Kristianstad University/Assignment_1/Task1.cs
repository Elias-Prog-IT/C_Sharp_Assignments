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
    class Task1
    {
        private string stringOne;
        private string stringTwo;

        public void taskOneStart()
        {
            ReadAndSaveData();
            DisplayTask1Info();
        }  

        public void ReadAndSaveData()
        {
            readStringOne();
            readStringTwo();
         
        }
        public void readStringOne()
        {
            Console.Write("Please enter the first string: ");
            stringOne = Console.ReadLine();
        }

        public void readStringTwo()
        {
            Console.Write("Please enter the second string: ");
            stringTwo = Console.ReadLine();
        }

        public void DisplayTask1Info()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            string textOut = "The result is: " + stringOne + " " + stringTwo ;
            Console.WriteLine(textOut);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

        }
    }
}
