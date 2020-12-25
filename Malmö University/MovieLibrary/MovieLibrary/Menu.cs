/*
	@Author Elias Posluk
	Student-id: AG3064
    Course: DA204A, Programming in C#
	@date 2017-10-22
	Assignment_1_Part_2, Movie Library
	Malmö University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Menu
    {
        public void meny()
        {
            int userInput = 0;
            Movie film = new Movie();
            Music music = new Music();
            do
            {

                Console.WriteLine("The extremely light database! \n");
                Console.WriteLine("What do you want to do: \n");
                Console.WriteLine("1. Movies." +
                Environment.NewLine + "2. Music." +
                Environment.NewLine + "3. Print out data." +
                Environment.NewLine + "4. Terminate program.");

                var ans = Console.ReadLine();
                int choice = 0;
                if (int.TryParse(ans, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            film.input();
                            break;
                        case 2:
                            Console.Clear();
                            music.input();
                            break;
                        case 3:
                            Console.Clear();
                            film.print();
                            Console.WriteLine("\n");
                            music.print();
                            break;
                        default:

                            break;
                    }
                }
                if (choice == 4)
                {
                    break;
                }

            } while (userInput != 5);

        }

    }
}
