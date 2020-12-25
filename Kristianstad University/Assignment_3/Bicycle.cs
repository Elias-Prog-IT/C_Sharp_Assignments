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
    class Bicycle
    {
        //privat statisk variabel
        private static int idSerie;
        //privata variabler
        private int bicycleId;
        private int bicycleSpeed;

        public int Speed
        {
            get
            {
                return bicycleSpeed;
            }
            set
            {
                bicycleSpeed = value;
            }
        }

        public int Id
        {
            get
            {
                return bicycleId;
            }
            set
            {
                bicycleId = value;
            }
        }

        public Bicycle()
        {
            bicycleId = ++idSerie;
            bicycleSpeed = 0;
        }


        public void Accelerate()
        {
            bicycleSpeed += 5;
        }


        public void Brake()
        {
            if (bicycleSpeed > 0)
            {
                bicycleSpeed -= 5;
            }
        }
    }
}