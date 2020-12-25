/*
    @Author: Elias Posluk
    Student-id: poel20ty
    Assignment 1, class Candy.cs
    .NET Core & C# programming
    @date 13/11/2020
*/
namespace Multifabriken
{
    class Car
    {
        //Gets the registration number
        public string carRegistrationNumber
        {
            get;
        }

        //gets the car colour
        public string carColour 
        {
            get;
        }

        //gets the car brand
        public string carBrand
        {
            get;
        }

        ///<summary>
        ///Initializes a new instance of the Car class
        ///</summary>
        public Car(string car_brand, string car_colour, string car_registrationNumber)
        {
            carBrand = car_brand;
            carColour = car_colour;
            carRegistrationNumber = car_registrationNumber;
        }

        ///<summary>
        ///Converts to string.
        ///A system string that represents this instance.
        ///</summary>
        public override string ToString()
        {
            return $"Car brand: {carBrand}, Color: {carColour}, Registration number: {carRegistrationNumber}.";
        }
    }
}