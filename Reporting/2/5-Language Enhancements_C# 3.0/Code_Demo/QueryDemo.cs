using System;
using System.Linq;
using System.Collections.Generic;


namespace Topic2Expressions
{
    public class QueryDemo
    {

        List<Student> students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill",Marks=92 },
                new Student(){ Id = 2, Name="Steve",Marks=80},
                new Student(){ Id = 3, Name="Ram",Marks=88},
                new Student(){ Id = 4, Name="Abdul",Marks=98},
                new Student(){ Id = 5, Name="Bill",Marks=93}
        };
        public void ShowDemo()
        {
			//Query Syntax
			//get all students whose name is Bill 
			IEnumerable<Student> querySyntax = from s in students
											   where s.Name == "Bill"
											   //where s.Marks>=90
											   orderby s.Marks descending
											   select s;
			foreach (var student in querySyntax)
			{
				Console.WriteLine(student.Id + ", " + student.Name);
			}
			var studNamesCount = querySyntax.Count();
			Console.WriteLine("--------------------------------------------------------");

			//Method Syntax
			//get all the student names and Id whose marks are greater than 90
			IEnumerable<Student> methodSyntax = students.Where(student => student.Marks > 90).OrderByDescending(student => student.Id);
			foreach (var item in methodSyntax)
			{
				Console.WriteLine(item.Id + ", " + item.Name);
			}
			Console.WriteLine("---------------------------------------------------------");

			//Mixed Syntax
			var mixedSyntax = (from obj in students
							   select obj.Marks).Max();
			Console.WriteLine("The Maximum Score is: " + mixedSyntax);
			Console.ReadLine();
		}
	
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}
