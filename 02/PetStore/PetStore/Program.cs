using System;
using System.Runtime.CompilerServices;
using PetLib;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args) // entry point
        {
            GetCat();
        }
        /// <summary>
        /// This function takes input from user and print those details in the formatted way
        /// </summary>
        private static void GetCat()
        {
            Cat pet1=new Cat();            
            Console.Write("Please enter your pet's Id: ");
            pet1.Id = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter your pet's name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your pet's birthday (yyyy/mm/dd): ");
            pet1.Dob = DateTime.Parse(Console.ReadLine());
            Console.Write("\nPlease enter you pet's Gender - press <0> for male and press <1> for female: ");
            byte gender = byte.Parse(Console.ReadLine());
            if (gender == 0)
                pet1.Gender = Gender.Male;
            else if (gender == 1)
                pet1.Gender = Gender.Female;
            else
                Console.Write("Incorrect gender press <0> for male and press <1> for female");
            pet1.CatType = CatType.Himalayan;
            Console.Write(pet1.GetDetails());
            pet1.GetMeal(pet1.Gender);
        }
    }
}
