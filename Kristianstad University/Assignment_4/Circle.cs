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
    class Circle : Shape
    {
        //private fields
        private double radius;

        //Constructor with 3 arguments
        public Circle(double _x, double _y, double _r) : base(_x, _y)
        {
            radius = _r;
        }

        //Overridden display method from base class
        public override string display()
        {
            return "X: " + x + ", Y: " + y + ", Circle Area: " + (2 * (3.14) * radius).ToString();
        }
    }
}
