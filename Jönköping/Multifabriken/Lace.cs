/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 1, class Candy.cs
    .NET Core & C# programming
    @date 13/11/2020
*/
namespace Multifabriken
{
    class Lace
    {
        //Gets the lace colour
        public string lace_Colour 
        {
            get;
        }

        //Gets the lace length
        public double lace_Length
        {
            get;
        }

        ///<summary>
        ///Initializes a new instance of the Lace class
        ///</summary>
        public Lace(string colour, double length)
        {
            lace_Colour = colour;
            lace_Length = length;
        }

        ///<summary>
        ///Converts to string.
        ///A system string that represents this instance.
        ///</summary>
        public override string ToString()
        {
            return $"Lace in colour {lace_Colour} and the length of {lace_Length} meters.";
        }
    }
}