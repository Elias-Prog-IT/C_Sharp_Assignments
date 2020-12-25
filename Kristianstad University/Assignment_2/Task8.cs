/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-01
	Assignment_2, Different Tasks Assignment
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Module2
{
    class Task8
    {
        public void displayTask8()
        {
            input();
        }

        private void input()
        {

            Console.Write("Enter an integer and press Enter key: ");
            int iA = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer and press Enter key: ");
            int iB = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the two integer is {0}", Sum(iA, iB));


            Console.Write("Enter a float and press Enter key: ");
            double doubleA = double.Parse(Console.ReadLine());
            Console.Write("Enter another float and press Enter key: ");
            double doubleB = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the two float is {0}", Sum(doubleA, doubleB));


            Console.Write("Enter the lastname and press Enter key: ");
            string stringA = Console.ReadLine();
            Console.Write("Enter the firstname and press Enter key: ");
            string stringB = Console.ReadLine();
            Console.WriteLine("Your name is {0}", Sum(stringA, stringB));


            Console.Write("Enter the real part of the first complex number and press Enter key: ");
            int realComplexA = int.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the first complex number and press Enter key: ");
            int imaginaryA = int.Parse(Console.ReadLine());
            Console.Write("Enter the real part of the second complex number and press Enter key: ");
            int secondRealB = int.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of the second complex number and press Enter key: ");
            int imaginaryB = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the two complex number is {0}", Sum(realComplexA, imaginaryA, secondRealB, imaginaryB));
        }

        private static int Sum(int a, int b)//addition
        {
            return a + b;
        }

        private static double Sum(double a, double b)//addition med decimaltal
        {
            return a + b;
        }

        private static string Sum(string a, string b)//sträng för namn
        {
            return string.Format("{0} {1}", a, b);
        }

        private static string Sum(int a, int b, int c, int d)//Overloading
        {
            return string.Format("{0}+ i{1}", a + c, b + d);
        }
    }
}