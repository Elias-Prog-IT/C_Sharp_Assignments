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
    class Music
    {
        private string artistName;
        private string genre;
        private int date;
        private double cost;

        public Music()
        {
            this.artistName = " ";
            this.genre = " ";
            this.date = 0;
            this.cost = 0.0;
        }

        public Music(string artist, string style, int year, double price)
        {
            this.artistName = artist;
            this.genre = style;
            this.date = year;
            this.cost = price;

        }

        public void setName(string name)
        {
            this.artistName = name;
        }
        public void setGenre(string style)
        {
            this.genre = style;
        }
        public void setYear(int date)
        {
            this.date = date;
        }

        public void setPrice(double cost)
        {
            this.cost = cost;
        }

        public string getName()
        {
            return artistName;
        }

        public string getGenre()
        {
            return genre;
        }

        public int getYear()
        {
            return date;
        }

        public double getPrice()
        {
            return cost;
        }

        public void input()
        {
            Console.WriteLine("Enter the name of the Artist: ");
            artistName = Console.ReadLine();
            Console.WriteLine("Enter the year of the music: ");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type of genre: ");
            genre = Console.ReadLine();
            Console.WriteLine("Enter the amount you purchased the music for: ");
            cost = Convert.ToDouble(Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("Name of the music: " + getName());
            Console.WriteLine("Type of genre: " + getGenre());
            Console.WriteLine("The year it got released: " + getYear());
            Console.WriteLine("The amount you purchased the movie for: " + getPrice());

        }
    }
}
