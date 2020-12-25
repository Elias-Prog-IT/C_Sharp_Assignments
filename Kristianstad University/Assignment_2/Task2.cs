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
    class Task2
    {

        public void displayTask2()
        {
            input();
        }

        private void input()
        {
            bool validInput = false;
            do
            {
                Console.Clear();
                Console.Write("Please enter an integer: ");
                validInput = int.TryParse(Console.ReadLine(), out int radius);

                for (int i = 1; i < radius; i++)//For-loop som skriver ut radius och volymen för spheren 
                {                               
                    Console.WriteLine("Sphere volume with radius {0} is {1:0.00}", i, CalculateSphereVolume(i));
                }


            } while (validInput == false);
        }

        private static double CalculateSphereVolume(int radius)//matematiska uträkningen för spherevolymen
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return volume;
        }
    }
}