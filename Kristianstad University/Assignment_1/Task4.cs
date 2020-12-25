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
    class Task4
    {
        protected string firstName, lastName;
        protected string initials, initial2, initial3;

        public void taskFourStart()
        {
            ReadAndSaveData();
            DisplayTask4Info();
        }

        public void ReadAndSaveData()
        {
            ReadFirstInitial();
        }

        private void ReadFirstInitial()
        {
            Console.WriteLine("Write in your first name here: ");
            firstName = Console.ReadLine().ToUpper();
            ReadSecondInitial();
        }

        private void ReadSecondInitial()
        {
            Console.WriteLine("Write in your last name here: ");
            lastName = Console.ReadLine().ToUpper();
            initials = firstName.Substring(0, 1) + "." + lastName.Substring(0, 1) + ".";
            initial2 = firstName.Substring(0, 1);
            initial3 = lastName.Substring(0, 1);
        }

        private void writeInitials()
        {
            Console.WriteLine(" E E E E E E E E E E E ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E E E E E E E E E E E ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E  ");
            Console.WriteLine(" E E E E E E E E E E E ");
            Console.WriteLine(" \n . \n");
            Console.WriteLine("       P  P  P           ");
            Console.WriteLine("    P            P           ");
            Console.WriteLine(" P                  P      ");
            Console.WriteLine(" P                    P  ");
            Console.WriteLine(" P                    P   ");
            Console.WriteLine(" P                    P   ");
            Console.WriteLine(" P                   P    ");
            Console.WriteLine(" P                 P      ");
            Console.WriteLine(" P               P   ");
            Console.WriteLine(" P             P     ");
            Console.WriteLine(" P          P         ");
            Console.WriteLine(" P  P  P P               ");
            Console.WriteLine(" P                   ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");
            Console.WriteLine(" P ");

        }

        private void DisplayTask4Info()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            string textOut = "Your initials are: " + initials;
            Console.WriteLine(textOut);
            writeInitials();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

    }
}