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
    class Menu
    {
        public void Meny()//menyn för att kalla på de två olika klasserna
        {

            CelsiusToFarenheit celsius = new CelsiusToFarenheit();
            FahrenheitToCelsius fahrenheit = new FahrenheitToCelsius();

            do
            {

                Console.WriteLine("\nAssignment2G\n");
                Console.WriteLine("What do you want to do? \n");
                Console.WriteLine("1. Convert Farenheit to Celcius. " +
                Environment.NewLine + "2. Convert Celsius to Farenheit.  " +
                Environment.NewLine + "3. Exit the program. ");

                var ans = Console.ReadLine();
                int choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1://Kallar på Fahrenheit-klassens display
                            Console.Clear();
                            fahrenheit.Display();
                            break;
                        case 2://Kallar på Celsius-klassens display
                            Console.Clear();
                            celsius.Display();
                            break;
                        default:
                            break;
                    }
                }
                if (choice == 3)//avslutar körning
                {
                    break;
                }

            } while (true);
        }
    }
}