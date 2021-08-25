## C# 7.0 features (Local functions, Expression-bodied members, Throw expressions)
 
####Local functions:
* In C#, 
Local functions are private methods of a type that are nested in another member. They can only be called from their containing member.
* Local functions make it easier for readers of the class to see that the local method is only called from the context in which it is declared.
* Local functions can be declared in and called from: Methods, especially iterator methods and async methods, Constructors, Property accessors, Event accessors, Anonymous methods, Lambda expressions, Finalizers, Other local functions
* There are two common use cases for local functions: public iterator methods and public async methods. Both types of methods generate code that reports errors later than programmers might expect. 
* In iterator methods, any exceptions are observed only when calling code that enumerates the returned sequence. 
* In async methods, any exceptions are only observed when the returned Task is awaited. 

**syntax:**
``` <modifiers> <return-type> <method-name> <parameter-list> ```

```
// C# program to illustrate local function
// accessing the variable of the function
// in which they present
using System;

public class Program {

	// Main method
	public static void Main()
	{
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
		AddValue(79, 70);
	}
}
```


### More expression-bodied members:
C# 6 introduced expression-bodied members for member functions and read-only properties. C# 7.0 expands the allowed members that can be implemented as expressions. 
Expression body definitions let you provide a member's implementation in a very concise, readable form. You can use an expression body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. 
In C# 7.0, you can implement constructors, finalizers, and get and set accessors on properties and indexers. 
Expression body definitions can be used with the type members.
**syntax:**
```member => expression;```
*__where expression is a valid expression__*

#### Expression-Bodied Methods in C#:
``` 
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

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Pranaya", "Rout");
        employee.DisplayName();
        Console.WriteLine(employee);
        Console.WriteLine("Press any key to exists");
        Console.ReadKey();
    }
}
```

#### Expression-Bodied Constructors in C#:
```
using System;  
  
namespace Tutpoint  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Instance of Operations class created  
            Operations ops = new Operations();  
            Console.ReadLine();  
        }  
    }  
  
    class Operations  
    {  
        public int Num1 = 100;  
        public int Num2 = 33;  
  
        // Constructor implemented using Expression Bodied  
        // This feature can only be used in C# 7.0 or onwards. Means In visual Studio 2017 and onwards.  
        public Operations()=> Num1= Num1+Num2;  
  
        // Destructor implemented using Expression Bodied  
        // Expression or right side followed with => must be valid and should be one statement  
        // Only assignment, call, increment, decrement, and new object expression can be used as a statement  
        // This feature can only be used in C# 7.0 or onwards. Means In visual Studio 2017 and onwards.  
        // If we try to implement this feature in visual studio 2015 then compiler will will not allow to do so and shows an error.  
        ~Operations()=> Console.WriteLine("Destructor is called");  
}  
} 
```



### Throw expressions:
* Throw Signals the occurrence of an exception during program execution.
* Throw expressions are the way to tell compiler to throw exception under specific conditions like in expression bodied members or inline comparisons.
* In C#, throw has always been a statement. Because throw is a statement, not an expression, there were C# constructs where you couldn't use it. These included conditional expressions, null coalescing expressions, and some lambda expressions. 
* The addition of expression-bodied members adds more locations where throw expressions would be useful. So that you can write any of these constructs, C# 7.0 introduces throw expressions.
This addition makes it easier to write more expression-based code. You don't need additional statements for error checking.
**syntax**:
```throw [e];```
*__where e is an instance of a class derived from System.Exception.__*



```
     public class Program
    {
        
        static void Main(string[] args)
        {
            string[] Days = { };
            var arrayFirstDay = Days.Length > 0 ? Days[1] : throw new Exception("Array is empty");
        }
    } 
```