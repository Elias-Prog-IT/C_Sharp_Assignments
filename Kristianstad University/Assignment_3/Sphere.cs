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
    class Sphere
    {
        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Sphere()
        { }

        public Sphere(int radiusInterval)
        {
            radius = radiusInterval;
        }

        //Räknar ut volymen till sphere
        public double GetVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return volume;
        }
    }
}
