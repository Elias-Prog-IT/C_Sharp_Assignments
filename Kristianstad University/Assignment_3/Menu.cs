/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-10-29
	Assignment_3, Different Tasks Assignment
	Kristianstad University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModule3
{
    class Menu
    {
        public void meny()
        {

            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
           
            do
            {

                Console.WriteLine("\nHomework Assignment 3\n");
                Console.WriteLine("What do you want to do? \n");
                Console.WriteLine(    "1. Represent the radius of the Sphere" +
                Environment.NewLine + "2. Account class" +
                Environment.NewLine + "3. Account class with menu" +
                Environment.NewLine + "4. Bicycle class" +
                Environment.NewLine + "5. HeartRate class" +
                Environment.NewLine + "6. Terminate Console.");

                var ans = Console.ReadLine();
                int choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            task1.display();
                            break;
                        case 2:
                            Console.Clear();
                            task2.display();
                            break;
                        case 3:
                            Console.Clear();
                          task3.display();
                            break;
                        case 4:
                            Console.Clear();
                            task4.display();
                            break;
                        case 5:
                            Console.Clear();
                            task5.display();
                            break;
                        default:
                            break;
                    }
                }
                if (choice == 6)
                {
                    break;
                }

            } while (true);

        }
    }
}