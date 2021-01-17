/*
   @Author Elias Posluk
   Student-id: AG3064
   Course: DA204A, Programming in C#
   @date 2017-09-22
   Assignment: grocery store light 
   Malmö University
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroceryStore
{
    class Product
    {

        private string name;
        private int count;
        private double value;
        private double resultFood;
        private const double foodVatRate = 0.12, otherVatRate = 0.25;
        
           public void Start()
        {
            ReadName();
            CalculateValues();
            PrintReceipt();
        }
        private void ReadInput()
        {
            ReadName();
            ReadNetUnitPrice();
            ReadIfFoodItem();
            ReadCount();
        }
        private String ReadName()
        {
            Console.Write("Enter the product name:     ");
             name = Console.ReadLine();
            return name;
        }

               
        private bool ReadIfFoodItem()
        {
            
            Console.Write("Food item (y/n):    ");
            char response = char.Parse(Console.ReadLine());
            if ((response == 'y') || (response == 'Y'))
                
                return true;
            else

                return false;
                 }

        private double ReadNetUnitPrice()
        {
            Console.WriteLine("Net unit price :");
            value = Double.Parse(Console.ReadLine());
            return value;

        }

        private int ReadCount()
        {
            Console.WriteLine("Count :");
            count = int.Parse(Console.ReadLine());
            return count;

        }

        private double CalculateValues()
          {
         if (ReadIfFoodItem() == true) { 
        resultFood = ReadNetUnitPrice() * foodVatRate * ReadCount();
         }

    else 
         {
        resultFood = ReadNetUnitPrice() * otherVatRate * ReadCount();
    }
    return resultFood;
}

        private void PrintReceipt()
        {
            Console.WriteLine("++++++++++WELCOME TO APU's SUPERMARKET+++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Name of the Product\t\t\t"+ name);
            Console.WriteLine("+++ Quantity           \t\t\t "+ count);
            Console.WriteLine("+++ Unit Price         \t\t\t" + value);

           
            if (ReadIfFoodItem() == true)
            {
                Console.WriteLine("+++ Including VAT at 12%: " + resultFood);
                Console.WriteLine("+++ Food Item"  );
            }
            else
            {
                Console.WriteLine("+++ Including VAT at 25%: " + resultFood);
                Console.WriteLine("+++ Food Item"  );
            }
            Console.WriteLine("+++ Total Amount to Pay: " + CalculateValues());
            Console.WriteLine("+++++++++++PLEASE COME AGAIN!++++++++++++++++++++++++++");
        }
    }

}
    
namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apu = new Product();
            apu.Start();
            Console.ReadLine();          
        }
    }
}