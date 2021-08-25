  ## Constructor : 
  * A constructor is a special method that is used to initialize objects.
  * Constructor doesnt have any return type/value, but method has.
  * Constructor should have same name that as class name!
  

  ```C#
  using System;

    namespace Constructor 
    {
    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear) //parametrized constructor
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        // Overloading of Constructor:
        // As simlilar to Methods Constructor can be also overloaded by using reference type!
        public Car(int modelYear, string modelName, string modelColor) //parametrized constructor
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

     }
    }
  ```


 ## Private Constructor:
* Private constructors are used in class that contains only static members. 
* The private constructor is always declared by using a private keyword.
* Using private constructor, prevents the creation of the instances of that class.

```C#
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

```


## Static Constructor:

* Static constructor does not take access modifiers.
* Static constructor does not  have parameters.
* Static constructor does not  have return type.
* Class or struct can only have one static constructor.
* We cannot call Static constructor.
* It automatically called by the compiler.
* It called only one time in its whole life.
* Compiler gives priority to static constructor.
* Static  constructors are use to :
    * To initialize the static data members.
    * To create the object of the class only one time.


```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bankObject = new Bank();
            Bank.showOne();
            bankObject.showAll();
            Console.ReadLine();
        }
    }
    public  class Bank
    {
        static readonly int empId = 101;

        static Bank()
        {
            empId = 102;
            Console.WriteLine("1.Static Constructor called.." + empId);
        }

        public Bank()
        {
            Console.WriteLine("2.Default Constructor called.." );
        }

        


        public static void showOne()
        {
            //empId = 103;
            Console.WriteLine("3.showOne method within bank class.");
        }
        public  void showAll()
        {
            Console.WriteLine("4.showall method within bank class.");
        }
    }
}

```

## Protected:
* The keyword "protects" the class from having its' constructor called by external classes.  However unlike the private keyword, protected will allow derived classes to access the class member
* A protected constructor means that only derived members can construct instances of the class (and derived instances) using that constructor.

* A protected member is accessible within its class and by derived class instances.

Example 1 :


```c#
using System;
class Test
{
protected int _x; private int _y;
}
class Test1 : Test
{
public Test1 ()
{
// In this we can  access the variable protected int but we cannot access private int variable
Console.WriteLine(this._x);
}
}
class Program
{
static void Main()
{ Test1 b = new Test1 (); }
}

```
Consider 2 classes, Test and Test1. Class Test1 is derived from Test. If we look inside the class Test, we can see two int field has been declared. 1 protected and 1 private.

In class B Test1 we can access the protected int, but we cannot access the private int. So the protected modifier gives us additional access in the derived class. So with the help of protected keyword, we can access the protected fields includes all the derived classes.

Example 2
In this example, the class DerivedPoint is derived from Point. Therefore, you can access the protected members of the base class directly from the derived class.

```C#
namespace ProtectedExample
{
class demo
{
// String Variable declared as protected
protected string name;
public void print()
{
Console.WriteLine("\name is " + name);
}
}
class Program
{
static void Main(string[] args)     // main method
{
demo d = new demo();
Console.Write("Enter your name:\t");
d.name = Console.ReadLine();
d.print();
Console.ReadLine();
}
}
}
```
In the above example, the string is declared as protected. This program will raise an error because protected will hide its members from other classes. So it will only accessible in child class.



