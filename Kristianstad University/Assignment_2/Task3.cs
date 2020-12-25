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
    class Task3
    {

        public void displayTask3()
        {
            input();
        }

        private void input()
        {
            bool validInput = false;
            int squareSize = 0;
            do
            {
                Console.Clear();
                Console.Write("Please enter the size of the square: ");
                validInput = int.TryParse(Console.ReadLine(), out squareSize);//felhantering inbyggd
            }
            while (validInput == false);

            drawRectangle(squareSize);
        }

        private void drawRectangle(int squareSize )
        {

            for (int i = 0; i < squareSize; i++)
            {
                for (int j = 0; j < squareSize; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
