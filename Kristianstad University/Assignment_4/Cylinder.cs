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
    class Cylinder : Shape
    {
        //private fields
        private double radius;
        private double height;

        //Constructor with 4 arguments
        public Cylinder(double _x, double _y, double _r, double _h) : base(_x, _y)
        {
            radius = _r;
            height = _h;
        }

        //Overridden display method from base class
        public override string display()
        {
            return @"X: " + x + ", Y: " + y + ", Cylinder Area: " + ((2 * (3.14) * radius * height) + (2 * (3.14) * (radius * radius))).ToString()
                + ", Cylinder Volume: " + ((3.14) * (radius * radius) * height).ToString();
        }
    }
}
