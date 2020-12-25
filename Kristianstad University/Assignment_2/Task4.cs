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
    class Task4
    {
        //privata variabler
        private const double worldPopulation = 6.5;
        private const double limitPopulation = 10;
        private const double incrementRate = 1.4;

        public void displayTask4()
        {
            worldPopulationCounter();
        }

        private void worldPopulationCounter()
        {
            double wordPopulation = worldPopulation;
            int year = DateTime.Now.Year;//tar hem dagens datum

            while (wordPopulation <= limitPopulation)
            {
                wordPopulation += wordPopulation * (incrementRate / 100);
                ++year;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The population will exceed {0} billion in {1}", limitPopulation, year);
            Console.ResetColor();
        }

    }
}
