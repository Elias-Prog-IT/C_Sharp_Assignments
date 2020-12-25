/*
	@Author Elias Posluk
	Student-id: AG3064
    Course: DA204A, Programming in C#
	@date 2017-10-22
	Assignment_1_Part_2, Movie Library
	Malmö University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Movie
    {
        private string name;
        private int date;
        private double cost;



        public Movie()
        {
            this.name = " ";
            this.date = 0;
            this.cost = 0.0;

        }

        public Movie(string movieGiven, int dateGiven, double costGiven)
        {
            this.name = movieGiven;
            this.date = dateGiven;
            this.cost = costGiven;

        }

        public void setName(string movieGiven)
        {
            this.name = movieGiven;
        }

        public void setYear(int dateGiven)
        {
            this.date = dateGiven;
        }

        public void setPrice(double costGiven)
        {
            this.cost = costGiven;
        }

        public string getName()
        {
            return name;
        }

        public int getYear()
        {
            return date;
        }

        public double getPrice()
        {
            return cost;
        }


        public override string ToString()
        {
            return this.name + " (" + date + " )";
        }


        public void input()
        {
            Console.WriteLine("Enter the name of the movie: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the year of the movie: ");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount you purchased the movie for: ");
            cost = Convert.ToDouble(Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("Name of the Movie: " + getName());
            Console.WriteLine("The year it got released: " + getYear());
            Console.WriteLine("The amount you purchased the movie for: " + getPrice());

        }
    }
}
