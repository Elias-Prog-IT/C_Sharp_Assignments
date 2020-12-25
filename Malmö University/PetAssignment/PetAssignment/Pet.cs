/*
	@Author Elias Posluk
	Student-id: AG3064
    Course: DA204A, Programming in C#
	@date 2017-10-20
	Assignment_1_Part_1, PetAssignment
	Malmö University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAssignment
{
    class Pet
    {
        private string name; // name of the pet
        private int age; // age is integer
        private bool isFemale = true; // true if female, otherwise male.
        private string gender; 
        public void Start()
        {
            Console.WriteLine(); 
            Console.WriteLine("Greetings from a Pet object! ");
            Console.WriteLine(); 

            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void ReadAndSavePetData()
        {
            ReadName();

            ReadAge();

            ReadGender();
        }

        public void ReadName()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
        }

        public void ReadAge()
        {
            Console.Write("What is the age of " + name + "? ");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue);
        }

        public void ReadGender()
        {
            Console.WriteLine("Is your pet a female (y/n)?");
            char response = char.Parse(Console.ReadLine().ToLower());

            if (response == 'y')
            {
                isFemale = true;
                gender = ("Female " + "\n" + name + " is a good girl!");
            }
            else
            {
                isFemale = false;
                gender = ("Male" + "\n" + name + " is a good boy!");
            }
        }

        public void DisplayPetInfo()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            string textOut = "Name: " + name + " \nAge: " + age + " \nGender: " + gender;
            Console.WriteLine(textOut);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}