// C# program to illustrate the
// concept of private Constructor
using System;

class Cons2
{

	// Variables
	public static string name;
	public static int num;

	// Creating private Constructor by using acces modifier "private"
	private Cons2()
	{

		Console.WriteLine("Welcome to Private Constructor");
	}

	// Public Constructor with parameters
	public Cons2(string a, int b)
	{

		name = a;
		num = b;
	}
}

