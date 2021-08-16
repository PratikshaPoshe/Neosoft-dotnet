// C# Program to demonstrate
// the execution of static
// constructor and non-static
// constructor
using System;

class Cons3
{

	// Declaration of
	// static constructor
	static Cons3()
	{
		Console.WriteLine("Static constructor");
	}

	// Declaration of
	// non-static constructor
	public Cons3()
	{
		Console.WriteLine("Non-Static constructor");
	}

	
}
