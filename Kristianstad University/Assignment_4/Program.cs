/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-11-11
	Assignment_4, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables
            double radius = 12.5;
            double height = 20.3;
            double x = 100;
            double y = 100;

            //Creating object of Shape class with passing 2 arguments to constructor x, y
            Shape _shape = new Shape(x, y);

            //Calling display function and printing return value
            Console.WriteLine(_shape.display());

            //Creating object of Circle class with passing 3 arguments to constructor x, y and radius
            Circle _circle = new Circle(x, y, radius);

            //Calling display function and printing return value
            Console.WriteLine(_circle.display());

            //Creating object of Cylinder class with passing 4 arguments to constructor x, y, radius, height
            Cylinder _cylinder = new Cylinder(x, y, radius, height);

            //Calling display function and printing return value
            Console.WriteLine(_cylinder.display());

            Console.ReadKey();
        }
    }
}
