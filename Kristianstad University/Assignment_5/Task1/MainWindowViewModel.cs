/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-11-25
	Assignment_5_task1, Different Tasks Assignment
	Kristianstad University
*/

using System;

namespace Task1
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title => "Task1: A Graphical application for Temperature Conversions";

        private string farenheit;

        private string celsius;

        public string Fahrenheit
        {
            get { return this.farenheit; }
            set
            {
                this.farenheit = value;
                this.RaisePropertyChanged();

                if (double.TryParse(value, out double parsed))
                {
                    this.Celsius = $"{ConvertToCelsius(parsed)} °C";
                }
                else
                {
                    this.Celsius = "Enter valid number";
                }
            }
        }

        public string Celsius
        {
            get { return this.celsius; }
            set
            {
                this.celsius = value;
                this.RaisePropertyChanged();
            }
        }

        public static double ConvertToCelsius(double fahrenheit)
        {
            return Math.Round((5 / 9d) * (fahrenheit - 32), 2);
        }
    }
}