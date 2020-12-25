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
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }

        public static void Task1()
        {
            Task1 task1Obj = new Task1();
            Console.WriteLine("TASK 1");
            task1Obj.taskOneStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.Clear();
            Task2 task2Obj = new Task2();
            Console.WriteLine("TASK 2");
            task2Obj.taskTwoStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }        public static void Task3()
        {
            Console.Clear();
            Task3 task3Obj = new Task3();
            Console.WriteLine("TASK 3");
            task3Obj.taskThreeStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        public static void Task4()
        {
            Console.Clear();
            Task4 task4Obj = new Task4();
            Console.WriteLine("TASK 4");
            task4Obj.taskFourStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();

        }

        public static void Task5()
        {
            Console.Clear();
            Task5 task5Obj = new Task5();
            Console.WriteLine("TASK 5");
            task5Obj.taskFiveStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        public static void Task6()
        {
            Console.Clear();
            Task6 task6Obj = new Task6();
            Console.WriteLine("TASK 6");
            task6Obj.taskSixStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        public static void Task7()
        {
            Console.Clear();
            Task7 task7Obj = new Task7();
            Console.WriteLine("TASK 7");
            task7Obj.taskSevenStart();
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
