/*
	@Author Elias Posluk
	Student-id: AG3064
    Course: DA204A, Programming in C#
	@date 2017-10-29
	Assignment_2G, CelsiusToFarenheit & FahrenheitToCelsius
	Malmö University
*/

using System;

namespace CelsiusToFarenheit
{

    class FahrenheitToCelsius
    {
        //sätter privata const variabler av typen double.
        private const double minTemp = 0.0;
        private const double maxTemp = 212.50;

        public void Display()//Display kallar bara på farenheitToCelcius metoden
        {
            FarenheitToCelcius();
        }

        private void FarenheitToCelcius()//användning av for-loop för att skriva ut listan
        {
            Console.WriteLine("{0,-10}{1,-10}", "Fahrenheit\t", "Celsius");
            for (double i = minTemp; i <= maxTemp; i += 4)
            {
                Console.WriteLine("{0,-10} = {1,-10}", i, (double)FarenheitCalculator(i));
            }
        }

        private static double FarenheitCalculator(double value) //Uträkningen för att få fram grader 
        {                                                       //från Farenheit till Celsius.
           return Math.Round((((value - 32) / 9) * 5), 2);
        }
    }
}