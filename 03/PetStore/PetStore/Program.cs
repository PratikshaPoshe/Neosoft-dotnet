using System;
using System.Runtime.CompilerServices;
using PetLib;
using System.IO;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args) // entry point
        { 
            //GetCat();
            PetData.FileRepo repo = new PetData.FileRepo();
            /*var newCat=AddCat();
            repo.Add(Mapper.Map(newCat));*/
            HealthStatus catHealth=new HealthStatus();
            try{
            var cats = repo.GetAllCats();
            foreach (var cat in cats)
            {
                var fbmi=catHealth.Fbmi(cat.RibCage, cat.LegLength);
                Console.WriteLine($"Id - {cat.Id} , Name- {cat.Name} \n |Breed- {cat.CatType} , Birthday- {cat.Dob.ToShortDateString()} \n |Weight- {cat.Weight} pounds , Gender- {cat.Gender} \n |Cat's Health- {catHealth.CatHealth(fbmi)}");
                Console.WriteLine("------------------------------------------------------");
            }
            }
            catch(DirectoryNotFoundException ex){
                Console.WriteLine("Invalid Directory");
            }
            catch(FileNotFoundException){
                Console.WriteLine("Invalid File");
            }
           
           /*Console.WriteLine("Please enter the name of the cat to be searched for ");
            var name=Console.ReadLine();
            var cat=repo.GetCat(name).Result;
            Console.WriteLine($"{cat.Id} {cat.Name} {cat.CatType} {cat.Dob} {cat.Weight} pounds {cat.Gender}");*/
            
            //SERIALIZATION
            //var cats=repo.Init();
            //repo.AddDummyCats(cats);//into XML
            //repo.AddDummyCats_Json(cats);//into JSON


        }
        /// <summary>
        /// This function takes input from user and print those details in the formatted way
        /// </summary>
        private static PetLib.Cat AddCat()
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
            Console.Write(" Please enter the weight of your cat in pounds ");
            pet1.Weight=Convert.ToDouble(Console.ReadLine());
            pet1.CatType = CatType.Himalayan;
            return pet1;
        }
    }
}
