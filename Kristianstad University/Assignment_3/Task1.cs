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
    class Task1
    {
        public void display()
        {
            //skapar två sphere objekt
            Sphere sphereA = new Sphere(5);
            Sphere sphereB = new Sphere(10);

            Console.WriteLine("The volume of the sphere A is {0:0.00}", sphereA.GetVolume());
            Console.WriteLine("The volume of the sphere B is {0:0.00}", sphereB.GetVolume());
        }
    }
}
