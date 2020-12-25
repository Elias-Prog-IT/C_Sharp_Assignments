/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 1, class Candy.cs
    .NET Core & C# programming
    @date 13/11/2020
*/

namespace Multifabriken
{
    //Class Candy
    class Candy
    {
        //Gets the candy taste
        public string candy_Taste
        {
            get;
        }

        //Gets the amount of candy
        public uint candy_Amount
        {
            get;
        }

        ///<summary>
        ///Initializes a new instance of the Candy class
        ///</summary>
        public Candy(string candy_taste, uint candy_amount)
        {
            candy_Taste = candy_taste;
            candy_Amount = candy_amount;
        }

        ///<summary>
        ///Converts to string.
        ///A system string that represents this instance.
        ///</summary>
        public override string ToString()
        {
            return $"{candy_Amount} pieces of candy with the taste of {candy_Taste}.";
        }
    }
}