/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 2, class Util.cs
    .NET Core & C# programming
    @date 29/11/2020
*/

using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Util
    {
        //Reads input from the console, if the input is empty 
        //the user gets a feedback.
        internal static string ReadInput(string message)
        {
            Console.Write(message);
            var line = Console.ReadLine();

            while (string.IsNullOrEmpty(line))
            {
                Console.Write("Value can't be empty! Please enter again : ");
                line = Console.ReadLine();
            }
            return line;
        }

        //Reads integer input from the console.
        internal static int ReadIntInput(string message)
        {
            Console.Write(message);
            var lineAsString = Console.ReadLine();

            int lineAsInt;
            while (!int.TryParse(lineAsString, out lineAsInt))
            {
                Console.Write("This is not a number! Please enter a numeric value : ");
                lineAsString = Console.ReadLine();
            }
            return lineAsInt;
        }

        //Writes the message on to the console.
        internal static void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.Write("\r\nPress \"Enter\" to return to \"Main Menu\"");
            Console.ReadLine();
        }

        //Prints out the tasks of the given list to the console.
        internal static void PrintTasks(List<Task> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(string.Format("{0}) {1} ", i + 1, list[i].ToString()));
        }
    }
}