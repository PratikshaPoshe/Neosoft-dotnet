using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Anonymous Types
            var v = new { Amount = 1008, Message = "Hello" };
            Console.WriteLine(v.Amount +" "+ v.Message + "\n" );

            // Example showing you cannot change the values
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.Write(student.Id); //output: 1
            Console.Write("\t"+student.FirstName); //output: James
            Console.Write("\t" + student.LastName + "\n\n"); //output: Bond

            // student.Id = 2;//Error: cannot chage value
            //    student.FirstName = "Steve";//Error: cannot chage value

            var student2 = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };

            // to get the name of the anonymous type
            Console.WriteLine(student2.GetType().ToString());
            Console.WriteLine("\n");


            //  LINQ Query returns an Anonymous Type

            IList<Student3> studentList = new List<Student3>() {
            new Student3() { StudentID = 1, StudentName = "John", age = 18 },
            new Student3() { StudentID = 2, StudentName = "Steve",  age = 21 },
            new Student3() { StudentID = 3, StudentName = "Bill",  age = 18 },
            new Student3() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student3() { StudentID = 5, StudentName = "Ron" , age = 21 }
        };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name);
            Console.WriteLine("\n");
            //illustrate how a method accept anonymous type as a parameter using dynamic type

            var anony_object = new
            {
                s_id = 134,
                s_name = "Siya",
                language = "Ruby"
            };

            // Calling mymethod
            mymethod(anony_object);
        }

        static public void mymethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.s_name);
            Console.WriteLine(val.language);
        }

    }

        
    
    public class Student3
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }
}
