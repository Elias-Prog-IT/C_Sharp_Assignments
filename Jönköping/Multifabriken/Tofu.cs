/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 1, class Candy.cs
    .NET Core & C# programming
    @date 13/11/2020
*/
namespace Multifabriken
{
    class Tofu
    {   
        //Gets the liter amount of tofu
        public double Liter_tofu 
        {
            get;
        }

        //Gets the seasoning for the tofu
        public string Seasoning_tofu 
        {
            get;
        }
        
        ///<summary>
        ///Initializes a new instance of the Tofu class
        ///</summary>
        public Tofu(string tofu_seasoning, double liters)
        {
            Liter_tofu = liters;
            Seasoning_tofu = tofu_seasoning;
        }

        ///<summary>
        ///Converts to string.
        ///A system string that represents this instance.
        ///</summary>
        public override string ToString()
        {
            return $"{Liter_tofu} liters of tofu, with seasoning: {Seasoning_tofu}.";
        }
    }
}