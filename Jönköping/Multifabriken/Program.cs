/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 1, class Candy.cs
    .NET Core & C# programming
    @date 13/11/2020
*/
using System.Collections.Generic;
using System;

namespace Multifabriken
{
    class Program
    {   
        /*
          A list that contains all items that the user orders. The list is a type of objects.
        */
        static List<object> items = new List<object>();
        static void Main(string[] args)
        {
            //Prints out a welcome text to the user.
            Console.WriteLine("Welcome to the multidimensional factory!");

            //A do-while loop to create a menu
            do
            {
                //A menu where the user has up to 4 products to choose from. The user can also list all the products and terminate the program
                Console.WriteLine("Please select a product you want to order (1-4), view all your products (5) or stop shopping (6).");
                
                //the menu
                Console.WriteLine("1. Lace" + Environment.NewLine +
                                  "2. Car" + Environment.NewLine +
                                  "3. Candy" + Environment.NewLine +
                                  "4. Tofu" + Environment.NewLine +
                                  "5. List all products" + Environment.NewLine +
                                  "6. Terminate shopping" + Environment.NewLine);

                //This reads the user input from the interaction to the menu
                var input = Console.ReadLine();

                /*
                    An error handler that checks if the user has put 
                    in a numerical range that is between 1-6. If the range is greater
                    or lower then the option given in the menu, then the error handler below
                    will inform the user about what went wrong and let the user try again.
                */
                if (!int.TryParse(input, out var choice))
                {
                    Console.WriteLine("You chose a number outside the menu range, try again!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        //Creates a new lace object and adds it to the list items.
                        items.Add(GetNewLace());
                        break;

                    case 2:
                        //Creates a new car object and adds it to the list items.
                        items.Add(GetNewCar());
                        break;

                    case 3:
                        //Creates a new candy object and adds it to the list items.
                        items.Add(GetNewCandy());
                        break;

                    case 4:
                        //Creates a new tofu object and adds it to the list items.
                        items.Add(GetNewTofu());
                        break;

                    case 5:
                        //Prints out all the products that the user selected
                        ShowOrderedItems();
                        break;

                    case 6:
                        //Terminates the program
                        Environment.Exit(0);
                        break;

                    default:
                        //If the user chooses an option that isn't exist, then the default messages
                        //informs the user about the wrong doing.     
                        Console.WriteLine("The option you chose does not exist, try again!");
                        break;
                }

            } while (true);

        }


        /*
        Creates a Lace object. 
       */
        private static Lace GetNewLace()
        {
            //Clearing the console from previous print out. 
            Console.WriteLine("You want to order Lace. Please enter the following criteria:");

            //Reads the criteria input by the user.
            Console.Write("Desired colour: ");
            var colour = Console.ReadLine();

            Console.Write("Desired length in meters: ");

            //Giving the variable length the datatype double.
            double length;

            //Keeps on looping until the user types in a valid length
            //As well as length is greater than 0.
            while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid length input, try again!");
            }

            //Creates a lace object
            var lace = new Lace(colour, length);

            //Prints out the object to show the user
            Console.WriteLine($"You ordered: {lace}");

            //Returns lace object
            return lace;
        }

        private static Car GetNewCar()
        {
            //Clearing the console from previous print out. 
            Console.WriteLine("You want to order a car. Please enter the following criteria:");

            //Reads the criteria input by the user.

            Console.Write("Car brand: ");
            var car_brand = Console.ReadLine();

            Console.Write("Desired car colour: ");
            var car_colour = Console.ReadLine();

            Console.Write("Desired registration number: ");
            var car_registrationNumber = Console.ReadLine();

            //creates a new car object
            var car = new Car(car_brand, car_colour, car_registrationNumber);


            //Prints out the car objects to show the user
            Console.WriteLine($"You ordered: {car}");


            //Returns car object
            return car;
        }

        private static Candy GetNewCandy()
        {
            //Clearing the console from previous print out. 
            Console.WriteLine("Soo..You want to order Candy, does your dentist agree to this?! Ehm..Please enter the following criteria:");

            //Reads the criteria input by the user.

            Console.Write("What taste do you desire: ");
            var candy_taste = Console.ReadLine();

            Console.Write($"Write down the amount of {candy_taste} that you want: ");

            //datatype "unit" can't store negative numbers, 
            //so this is precaution with the datatype for the variable candy_amount. 
            uint candy_amount;

            //Looping until the candy amount is not under 0 or just 0.
            while (!uint.TryParse(Console.ReadLine(), out candy_amount) || candy_amount == 0)
            {
                Console.WriteLine("Invalid candy amount, try again!");
            }

            //Creates a candy object.
            var candy = new Candy(candy_taste, candy_amount);

            //Prints out the candy objects to show the user
            Console.WriteLine($"You ordered: {candy}");
            //Returns candy object.
            return candy;
        }


        private static Tofu GetNewTofu()
        {
            //Clearing the console from previous print out. 
            Console.WriteLine("You want to order tofu. Please enter the following criteria: ");

            //Reads the criteria input by the user.

            Console.Write("Choose your desired seasoning for the tofu: ");
            var tofu_seasoning = Console.ReadLine();

            Console.Write("How many liters of the tofu do you want: ");

            //Liters can be a double value, the reason the datatype double is chosen
            double liters;
            //Keeps on looping until the input is greater than 0 and a valid value
            while (!double.TryParse(Console.ReadLine(), out liters) || liters <= 0)
            {
                Console.WriteLine("Invalid input on amount of liters, try again!");
            }

            //Creates a tofu object
            var tofu = new Tofu(tofu_seasoning, liters);

            //Prints out the tofu objects to show the user
            Console.WriteLine($"You ordered: {tofu}");

            //Returns tofu object 
            return tofu;

        }

        //Shows all the ordered items that the user has picked.
        private static void ShowOrderedItems()
        {   //Shows how many items the user has ordered
            Console.WriteLine($"You ordered {items.Count} products.");

            //Iterates for each item in the list and prints it out for the user
            foreach (var product in items)
            {
                //every product in the list Items object gets overriden to ToString method
                Console.WriteLine(product.ToString());
            }
        }

    }//program
}//namespace