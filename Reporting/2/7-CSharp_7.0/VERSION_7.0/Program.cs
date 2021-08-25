using System;

namespace VERSION_7._0
{
	//Expression-Bodied Methods in C#:
	public class Employee
	{
		private string FirstName;
		private string LastName;

		public Employee(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public string GetFullName() => $"{FirstName} {LastName}";

		public void DisplayName() => Console.WriteLine(GetFullName());
	}

	//End

	//Expression-Bodied constructor in C#:
	class Student
	{
		public string Name { get; set; }
		// Expression Constructor  
		public Student(string name) => Name = name;
	}
	
	// End

	class Version_7
    {
        static void Main(string[] args)
        {
				// Main method
				// Variables of main method
				int x = 40;
				int y = 60;

				// Local Function
				void AddValue(int a, int b)
				{
					Console.WriteLine("Value of a is: " + a);
					Console.WriteLine("Value of b is: " + b);
					Console.WriteLine("Value of x is: " + x);
					Console.WriteLine("Value of y is: " + y);
					Console.WriteLine("Sum: {0}", a + b + x + y);
					Console.WriteLine();
				}

				// Calling Local function
				AddValue(50, 80);

				//Expression-Boddied Method example
				//Employee emp = new Employee("Alfaiz","Khan");
				//emp.DisplayName();

				//Expression-Boddied Constructor example
				//Student student = new Student("Rahul");
				//Console.WriteLine($"Hello {student.Name}");

				//Throw Exception Example
				//string[] Days = { };
				//var arrayFirstDay = Days.Length > 0 ? Days[1] : throw new Exception("Array is empty");
		}
    }
}
