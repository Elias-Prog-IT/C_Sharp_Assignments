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
    class PetOwnerMain
    {
        static void Main(string[] args)
        {

            Pet petObj = new Pet();

            petObj.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
