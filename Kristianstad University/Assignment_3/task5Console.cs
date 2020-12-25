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
    class task5Console
    {
      
        //Skriver ut en formaterad text till consolen
        public static void WriteLine(string message, ConsoleColor color = ConsoleColor.White, Alignment alignment = Alignment.Left)
        {
            if (alignment == Alignment.Center)
            {
                Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public static void Write(string message, ConsoleColor color = ConsoleColor.White, Alignment alignment = Alignment.Left)
        {
            if (alignment == Alignment.Center)
            {
                Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
            }
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        //placering på texten
        internal enum Alignment { Left, Center }
    }
}
