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
    class Task1
    {
        private const int numberOfIntegers = 10;
        public void displayTask1()//skriver ut värderna för square och cube, up till 10 integers
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Number", "Square", "Cube");
            for (int i = 1; i <= numberOfIntegers; i++)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", i, Math.Pow(i, 2), Math.Pow(i, 3));
            }
        }
    }
}
