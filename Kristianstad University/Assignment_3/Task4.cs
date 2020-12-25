/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-29
	Assignment_3, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModule3
{
    class Task4
    {
        public void display()
        {
            Bicycle[] bikes = new Bicycle[3];
            Random rnd = new Random();

            //Bygger upp cyklarna och kallar på random funktionen
            for (int i = 0; i < bikes.Length; i++)
            {
                bikes[i] = new Bicycle();

                for (int j = 0; j < rnd.Next(3, 10); j++)
                {
                    bikes[i].Accelerate();
                }
                for (int j = 0; j < rnd.Next(1, 3); j++)
                {
                    bikes[i].Brake();
                }
            }

            //Visar cyklarnas stats
            for (int i = 0; i < bikes.Length; i++)
            {
                Console.WriteLine("======== Bike {0} ========", i + 1);
                Console.WriteLine("Id: {0}", bikes[i].Id);
                Console.WriteLine("Speed: {0}", bikes[i].Speed);
                Console.WriteLine();
            }
        }
    }
}
