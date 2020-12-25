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
   
    class Task3
    {
        struct variableContainer
        {
            public int i;
            public double x, number1, number2, number3;
        }

        variableContainer container1 = new variableContainer();

            public void taskThreeStart()
            {
                readAndSaveData();
                DisplayTask3Info();
            }

            public void readAndSaveData()
            {

            do
            {
                container1.number1 = readingInput();
                container1.number2 = readingInput();
                container1.number3 = readingInput();

            } while (container1.number3 <= 0);

            }

        public double readingInput()
        {
            container1.i++;
            Console.WriteLine("Mata in ett värde:");
            Console.WriteLine("Tal "+ container1.i +" :" );
            container1.x = double.Parse(Console.ReadLine());
            
            return container1.x;
        }

        private void DisplayTask3Info()
        {
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("första talet: \t andra talet:\t tredje talet:\n" + "{0}\t\t{1}\t\t{2}",
                container1.number1, container1.number2, container1.number3);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

    }
}
