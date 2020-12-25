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
    class Menu
    {
        public void meny()
        {
           
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
            Task6 task6 = new Task6();
            Task7 task7 = new Task7();
            Task8 task8 = new Task8();
            do
            {

                Console.WriteLine("\nHomework Assignments\n");
                Console.WriteLine("What do you want to do? \n");

                Console.WriteLine(    "1. Display the square and cubic values of ten integers" +
                Environment.NewLine + "2. Compute the volume of Sphere with their Radius" +
                Environment.NewLine + "3. Sphere's volume with radius" +
                Environment.NewLine + "4. Assuming the world population, counting from today" +
                Environment.NewLine + "5. Converting from Celcius to Fahrenheit " +
                Environment.NewLine + "6. Application that prompts students to enter their grade " +
                Environment.NewLine + "7. Calculating the minimum number " +
                Environment.NewLine + "8. Overloading methods!" +
                Environment.NewLine + "9. Terminate Console.");

                var ans = Console.ReadLine();
                int choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            task1.displayTask1();
                            break;
                        case 2:
                            Console.Clear();
                           task2.displayTask2();
                            break;
                        case 3:
                            Console.Clear();
                            task3.displayTask3();
                            Console.WriteLine("\n");
                         
                            break;
                        case 4:
                            Console.Clear();
                            task4.displayTask4();
                            break;
                        case 5:
                            Console.Clear();
                            task5.displayTask5();
                            break;
                        case 6:
                            Console.Clear();
                            task6.displayTask6();
                            break;
                        case 7:
                            Console.Clear();
                            task7.displayTask7();
                            break;
                       case 8:
                            Console.Clear();
                            task8.displayTask8();
                            break;
                        default:

                            break;
                    }
                }
                if (choice == 9)
                {
                    break;
                }

            } while (true);

        }
    }
}
