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
    class CelsiusToFarenheit
    {
        //sätter privata const variabler av typen double.
        private const double minTemp = 0.0;
        private const double maxTemp = 100.0;

        public void Display()//Display kallar bara på CelsiusToFarenheit metoden
        {
            CelciusToFarenheit();
        }

        private void CelciusToFarenheit()//användning av for-loop för att skriva ut listan
        {
            Console.WriteLine("{0,-10}{1,-10}", "Celsius", "Fahrenheit");
            for (double i = minTemp; i <= maxTemp; i += 5)
            {
                Console.WriteLine("{0,-10} = {1,-10}", i, CelsiusCalculator(i));
            }
        }

        private static double CelsiusCalculator(double value)//Uträkningen för att få fram grader från celcius till farenheit.
        {
            return value * (9.0 / 5.0) + 32;
        }
    }
}