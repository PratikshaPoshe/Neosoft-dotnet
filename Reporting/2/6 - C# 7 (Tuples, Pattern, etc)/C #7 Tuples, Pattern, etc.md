#Tuples
- Tuples are lightweight data structures that contain multiple fields to represent the data members. 
- They are useful for multiple return values.
- Tuples were available before C# 7.0, but they were inefficient.
- C# 7.0 introduces language support for tuples, which enables semantic names for the fields of a tuple using new, more efficient tuple types.
- You can create a tuple by assigning a value to each member, and optionally providing semantic names to each of the members of the tuple:
```csharp
(string A, string B) letters = ("a", "b");
Console.WriteLine($"{letters.A}, {letters.B}");
```
- You can also specify the names of the fields on the right-hand side of the assignment:
```csharp
var alphabet = (A: "a", B: "b");
Console.WriteLine($"{alphabet.A}, {alphabet.B}");
```
***
**Consuming Tuples Tradionally.**

```
(string Name, int Age, string Location) LookupName(long id)
{
    return ("Joe", 25, "Mumbai");
}

var names = LookupName(id);
WriteLine($"Details {names.Name} {names.Age} {names.Location}");
```

**What is Deconstruction?**
- Deconstruction declaration is used to consume Tuples.
- This simply splits a Tuple into its individual parts and assigns these parts to new variables. This is called deconstruction.
- And it is not only reserved for Tuples, any type can support Deconstruction Feature as long as there is Deconstruction Method defined for it either as a member or an extension Method.

**Consuming Tuples using Deconstructor**
```
(string Name, int Age, string Location) LookupName(long id)
{
    return ("Joe", 25, "Mumbai");
}
```
```
(var Name,var Age,var Location) = LookupName(id1) // using var for the individual variables declared.
```
or
```
var(Name,Age,Location) = LookupName(id2); //putting a single var outside of the parentheses as an abbreviation.
```
or
```
(Name, Age, Location) = LookupName(id3); // If variables declared already.
```
```
WriteLine($"Details {Name} {Age} {Location}");
```

```
class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) { X = x; Y = y; }
    public void Deconstruct(out int x, out int y) { x = X; y = Y; }
}

(var myX, var myY) = GetPoint(); // calls Deconstruct(out myX, out myY);
```

**Why does it use out parameters instead of returning a tuple?** 
- The out parameters constitute the values that result from the deconstruction.
- That is so that you can have multiple overloads for different numbers of values.
- It will be a common pattern to have constructors and deconstructors be "symmetric" in this way.
- Just as for out variables, we allow "discards" in deconstruction, for things that you don’t care about.

```
(var myX, _) = GetPoint(); // I only care about myX
```
***
### Pattern Matching :
Pattern matching is a feature that was introduced in C# 7. It allows you to check whether an object is of a particular 
type and check its value in a concise way through the use of is patterns and case patterns. We can use the when keyword to specify additional rules to the pattern.

1. The is pattern

* The is pattern allows you to check whether a variable is of a certain type, and then assign it to a new variable.
Further checks can then be made on that variable. The following code checks if a variable is an int, and if so, adds it to the current sum:
   ``` C#
   if (input is int count)
       sum += count;
   ```   
   You can test against value types as well as reference types, and you can assign the successful result to a new variable of the correct type. 

* This pattern can also be used to check if a variable is null:

     if (input is null)

     This second statement is guaranteed to do a null reference check. When you use == null, the operator== might be overloaded, causing a different check to be performed.

2. The case pattern

    The switch statement cases also support patterns. These patterns can include a type check, plus additional conditions.
    The switch match expression has a familiar syntax, based on the switch statement already part of the C# language. The updated switch statement has several new constructs:
    * The governing type of a switch expression is no longer restricted to integral types, Enum types, string, or a nullable type corresponding to one of those types. Any type may be used.
    * You can test the type of the switch expression in each case label. As with the is expression, you may assign a new variable to that type.
    * You may add a when clause to further test conditions on that variable.
    * The order of case labels is now important. The first branch to match is executed; others are skipped.

   ``` csharp
        switch (i)
        {
            case 0:
                break;
            case IEnumerable<int> childSequence:
            {
                foreach(var item in childSequence)
                    sum += (item > 0) ? item : 0;
                break;
            }
            case int n when n > 0:
                sum += n;
                break;
            case null:
                throw new NullReferenceException("Null found in sequence");
            default:
                throw new InvalidOperationException("Unrecognized type");
        }
    ```
    - case 0: is a constant pattern.
    - case IEnumerable<int> childSequence: is a declaration pattern.
    - case int n when n > 0: is a declaration pattern with an additional when condition.
    - case null: is the null constant pattern.
    - default: is the familiar default case.   
    ***
    C# 8.0 introduces nullable reference types and non-nullable reference types that enable you to make important statements
about the properties for reference type variables:

## What are nullable and non-nullable reference type?##
Any reference type which can has a null value is called as nullable reference type 
whereas in non-nullable reference type it means we can have a reference type and that cannot be set as null. 
i.e We can set it as null but it will give a compiler warning and this can be done in two different form:-

**1.Changing Project property.
  2.Through using a directory in the file.**

string? name;Now, when we declare a type or a project which is nothing but a component as non-nullable, we essenially expressing our intent that any types or any reference type declared inside of this component or class are non-nullable. 

Any variable where the '?' isn't appended to the type name is a non-nullable reference type.

 **Example,the following variable declaration represents a nullable string variable, name:**
'''C#
string? name;
'''
---
**Main Program**
'''C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonNullableReferenceTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}

'''

**class**
'''C#

namespace NonNullableReferenceTypeDemo
{
	internal class NullableType()
	{
		public string NonNullableProperty { get; set; }
	}
}
'''

**class**
'''C#


namespace NonNullableReferenceTypeDemo
{
	internal class TestNonNullable()
	{
		public void Test()
        {
        NonNullableType nonNullableType = null;
        Console.WriteLine(nonNullableType.NonNullableProperty);
        }

    }
}'''

