/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-09-20
	Assignment_1, Different Tasks Assignment
	Kristianstad University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Task5
    {

       private int num1, radious;
       private double circumference, pow;
       private double pi = Math.PI;

        public void taskFiveStart()
        {
            ReadAndSaveData();
            DisplayTask5Info();
        }

        public void ReadAndSaveData()
        {
            readIntegerOne();
        }

        public void readIntegerOne()//Läser in input från användaren
        {
            Console.Write("Type in the radius of the circle: ");
            num1 = Convert.ToInt32(Console.ReadLine());
        }

        public int calculateRadious()//Funktion för att räkna ut radien  
        {
             radious = 2 * num1;
             return radious;
        }
        public double calculateCircumference()//Funktion för att omkrets  
        {
            circumference = Math.Round(2 * pi * num1,2);
            return circumference;
        }

        public double calculatePow()//Funktion för att räkna exponent
        {
            pow = Math.Round(pi * Math.Pow(num1, 2), 2);
            return pow;
        }

        public void DisplayTask5Info()//Skriver ut värderna
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            string textOut = "Diameter = " + calculateRadious() + "\n" + "Circumference = " + calculateCircumference() + "\n" +"Area =" + calculatePow();
            Console.WriteLine(textOut);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
