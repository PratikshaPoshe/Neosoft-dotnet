using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car Ford = new Car("Mustang", "Red", 2009);    //obj 1
            // variable can be also intailzed with help of object but its not good practice and 
            // bad eg of code re-usability
            //Car Audi = new Car("A8", "White", 2005);    //obj 2


            /* Console.WriteLine("Model Name: " + Ford.model);
             Console.WriteLine("Color :" + Ford.color);
             Console.WriteLine("Model year :" + Ford.year); 

            Car Swift = new Car(2008, "Dezire", "Blue");
            Console.WriteLine("Model year :" + Swift.year);
            Console.WriteLine("Model Name: " + Swift.model);
            Console.WriteLine("Color :" + Swift.color);
            Console.ReadLine();


            Cons2 obj = new Cons2("krunal", 22);
            Console.WriteLine(Cons2.name + ", " + Cons2.num);
            Console.ReadLine(); */


            Cons3 obj1 = new Cons3();
            Cons3 obj2 = new Cons3();
            Console.ReadLine();




        }
    }
}