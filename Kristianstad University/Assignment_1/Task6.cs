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
    class Task6
    {

        private int numbers, temp, sum;
        int i = 0;
        private int[] array = new int[4];

        public void taskSixStart()
        {
            ReadAndSaveData();
        }

        public void ReadAndSaveData()
        {
            ReadInput();
        }

        private void ReadInput()
        {
            Console.WriteLine("Please enter four digits: ");
            numbers = Convert.ToInt32(Console.ReadLine());
            temp = numbers;
            Calculate();
        }

        private void Calculate()
        {
            while (numbers > 0)
            {
                array[i] = numbers % 10;
                sum = sum + array[i];
                numbers = numbers / 10;
                i++;
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
