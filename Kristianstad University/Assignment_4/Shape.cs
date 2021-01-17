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
    class Shape
    {
        //Protected fields that can be accessed in child classes
        protected double x;
        protected double y;

        //Constructor with two arguments
        public Shape(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        //display method which is to be overridden in child classes
        public virtual string display()
        {
            return "X: " + x + ", Y: " + y;
        }
    }
}
