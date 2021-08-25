using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class ObjectInitializer
    {
        public static void ColCode()
        {
            List<Student> students = new List<Student> {
                new Student { ID=101, Name="Rahul", Email="rahul@example.com" },
                new Student { ID=102, Name="Peter", Email="peter@abc.com" },
                new Student { ID=103, Name="Irfan", Email="irfan@example.com" }
            };
            foreach (Student student in students)
            {
                Console.Write(student.ID + " ");
                Console.Write(student.Name + " ");
                Console.Write(student.Email + " ");
                Console.WriteLine();
            }
        }
    }
}
