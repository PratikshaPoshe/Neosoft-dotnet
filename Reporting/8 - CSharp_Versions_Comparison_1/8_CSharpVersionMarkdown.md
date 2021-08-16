#Introduction:
##History of C#:

Here we compare the various csharp versions and how C# has evolved over the period of time. C# is an incrementation of C++. C# language has accomodated several major features to evolve as a programming language over the years.

##C# Version 1.0:
In the year 2002, the first version of C# was released along with the dotnet framework 1.0 as a modern object oriented type safety programming language. C# version 1.0 was considered to be a workable alternative to Java on Windows platform.

####Features:
- Classes: One of the reference type available in C#.
- Structs: It is a value type used for encapsulating data and its related functionalites.
- Interfaces: it is like an abstract class containing abstract methods.
- Events: used by object to broadcast about something
- Properties: properties are members of a class, considered as special methods(called accessors).
- Delegates: they are types in C# that shows references to methods (similar to C++ function pointers).
- Operators and Expressions: operators allow to perform operations on values (operands). Expressions are evaluated to give an output value.
- Statements: statements are instructions executed or actions that a program takes.
- Attributes: attributes are used to add metadata to our program.

##C# Version 1.2:
C# version 1.2 was released in the year 2002, following the release of version 1.0.

####Features:
- Basic features (OOPS, type safety, structured programming etc.)

##C# Version 2.0:
When C# version 2.0 was released in the year 2005, there was not only addition of new features but also enhancement of the existing features.

####Enhancements:
- Introduction to Static classes
- Getter/setter separate accessibility

####Features:
- Generics: C# uses generic classes, methods,operators etc. using the type parameter without specifying the datatype. (Basically, Integer, String and user-defined types can be parameter to methods, classes and interfaces)
- Anonymous methods: methods without a name
- Nullable value types: variables can be assigned null values.
- Iterators: method used to iterate over/ retrive elements of an array or collection, one by one.
- Covariance & contravariance: ability to use a more or less derived type than originally specified. 
###version 3.0 - C# version 3.0 came in late 2007, along with Visual Studio 2008, though the full boat of language features would actually come with .NET Framework version 3.5. 
- This version marked a major change in the growth of C#. It established C# as a truly formidable programming language. Let's take a look at some major features in this version:
* Auto-implemented properties :- In C# 3.0 and later, auto-implemented properties make       property-declaration more concise when no additional logic is required in the property accessors.
* Anonymous types :- Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first.
* Query expressions :- A query is a set of instructions that describes what data to retrieve from a given data source (or sources) and what shape and organization the returned data should have. 
* Lambda expressions :- You use a lambda expression to create an anonymous function. 
* Expression trees :- An Expression Tree is a data structure that defines code. 
* Extension methods :- Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
* Implicitly typed local variables :- Beginning with C# 3, variables that are declared at method scope can have an implicit "type" var. An implicitly typed local variable is strongly typed just as if you had declared the type yourself, but the compiler determines the type. 
* Partial methods :- A partial method has its signature defined in one part of a partial type, and its implementation defined in another part of the type. 
* Object and collection initializers :- Object initializers let you assign values to any accessible fields or properties of an object at creation time without having to invoke a constructor followed by lines of assignment statements.

###Version 4.0 - C# version 4.0, released with Visual Studio 2010, would have had a difficult time living up to the groundbreaking status of version 3.0.
- With version 3.0, C# had moved the language firmly out from the shadow of Java and into prominence. The language was quickly becoming elegant.
The next version did introduce some interesting new features:
* Dynamic binding
* Named/optional arguments :- C# 4 introduces named and optional arguments. Named arguments enable you to specify an argument for a parameter by matching the argument with its name rather than with its position in the parameter list.
* Generic covariant and contravariant :- Covariance and contravariance are terms that refer to the ability to use a more derived type (more specific) or a less derived type (less specific) than originally specified. Generic type parameters support covariance and contravariance to provide greater flexibility in assigning and using generic types.
* Embedded interop types :- Beginning with the .NET Framework 4, the common language runtime supports embedding type information for COM types directly into managed assemblies, instead of requiring the managed assemblies to obtain type information for COM types from interop assemblies.
- The major feature was the introduction of the dynamic keyword. The dynamic keyword introduced into C# version 4.0 the ability to override the compiler on compile-time typing.
- By using the dynamic keyword, you can create constructs similar to dynamically typed languages like JavaScript. You can create a dynamic x = "a string" and then add six to it, leaving it up to the runtime to sort out what should happen next.

###Version 5.0 - C# version 5.0, released with Visual Studio 2012, was a focused version of the language. Nearly all of the effort for that version went into another groundbreaking language concept: the async and await model for asynchronous programming. Here's the major features list:

* Asynchronous members
* Caller info attributes - The caller info attribute lets you easily retrieve information about the context in which you're running without resorting to a ton of boilerplate reflection code. It has many uses in diagnostics and logging tasks.

## C# Version 6.0 New Features

[**1. Static imports**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static)

This is a new concept in C# 6.0 that allows us to use any class that is static as a namespace that is very useful for every developer in that code file where we need to call the static methods from a static class like in a number of times we need to call many methods from Convert.ToInt32() or Console.Write(),Console.WriteLine() so we need to write the class name first then the method name every time in C# 5.0. In C# 6.0 however Microsoft announced a new behavior to our cs compiler that allows me to call all the static methods from the static class without the name of the classes because now we need to first use our static class name in starting with all the namespaces.
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/BlogImages/09182016190247PM/image001.jpg)
***
[**2. Auto-property Initializer**](https://docs.microsoft.com/en-us/dotnet/csharp/properties)

Auto property initializer is a new concept to set the value of a property during of property declaration. We can set the default value of a read-only property, it means a property that only has a {get;} attribute. In the previous version of C# 5.0 we can set the values of the property in the default constructor of the class. Here we can set the default value of my property in only by constructors.

![alt text](https://www.codeproject.com/KB/cs/846567/EmployeeClass.png)
***
[**3. nameof Operator**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)

nameof is new keyword in C# 6.0 and it's very useful from a developer's point of view because when we need to use a property, function or a data member name into a message as a string so we need to use the name as hard-coded in “name” in the string and in the future my property or method's name will be changed so it must change all the messages in every form or every page so it's very complicated to remember that how many number of times you already use the name of them in your project code files and this avoids having hardcoded strings to be specified in our code as well as avoids explicit use of reflection to get the names.
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8ef97c/full-C-Sharp-6-0-in-single-article-on-visual-studio-2015-preview/Images/nameof.jpg)
***
[**4. Exception filters**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/when)
Exception filters allow us to specify a condition with a catch block so if the condition will return true then the catch block is executed only if the condition is satisfied. This is also the best attribute of new C# 6.0 that makes it easy to do exception filtrations in also that type of code contains a large amount of source code. 
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/7ca517/exception-filter-in-C-Sharp-6-0/Images/ExceptionFilterNotSupported.png)
***
[**4. Null-conditional operators**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)
The null-conditional operators are short-circuiting. That is, if one operation in a chain of conditional member or element access operations returns null, the rest of the chain doesn't execute. 
![alt text](https://www.codeproject.com/KB/cs/850832/C__6.0_-_Nested_Conditions__www.kunal-chowdhury.com__3_.png)
***
[**4. Expression–Bodied Methods**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator#expression-body-definition)
An Expression–Bodied Method is a very useful way to write a function in a new way and also very useful for those methods that can return their value by a single line so we can write those methods by using the “=>“ Lambda Arrow Operator in C# 6.0.
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/16101a/expression-bodied-members-a-new-feature-of-C-Sharp-6-0/Images/Lambda%20Expression.jpg)
***
[**4. String Interpolation**](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
To easily format a string value in C# 6.0 without any string.Format() method we can write a format for a string. It's a very useful and time consuming process to define multiple string values by “\{ variable }”. So let's have an example on String interpolation.
![alt text](https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/8ef97c/full-C-Sharp-6-0-in-single-article-on-visual-studio-2015-preview/Images/variable.jpg)
***
## C# Version 7.0 New Features

[**1. Pattern Matching**](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#pattern-matching)
Pattern matching allows you to implement method dispatch on something other than the object's type. For example, when you inherit a class and overload one of its methods, the dispatcher knows which method to call based on the type of the object calling it. Pattern matching expressions allow you to implement similar dispatching rules for elements not related via inheritance. That's a bit of a mouthful, so bear with me and I'll give you some practical examples shortly.

Pattern matching in C# 7 improves upon two previously existing language constructs: is expressions and switch statements.
```csharp
if (obj is null) ...
if (obj is string) ...
```
***
[**2. Ref Locals and the Ref Return**](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#ref-locals-and-returns)
You've always been able to pass in values by reference (via the ref keyword), but now you can also store them by reference locally, and return them by reference as well.

This is very handy when working with large data structures, such as a matrix or map array populated by structs that contain information about each location on the grid (video games, anyone?). You can now return a reference to the location of the data, rather than the data itself. This allows you to read and modify it very efficiently, without having to copy values or perform repeated costly de-referencing operations.
```csharp
static ref int GetItem(int ID, int[,] items)
{
    for (int item=0; item < items.Length; item++)
    {
        if (items[item] == ID)
        {
            return ref items[item];
        }
    }
}
// You can also store the result in a local ref
ref int item = ref GetItem(237, arrItems);

```
***
[**3. Local Functions**](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions)
Local functions are methods declared inside other methods. This makes it immediately obvious that the local method isn't called from anywhere else. It may seem counter-intuitive to start cluttering up your nice, readable methods with single use methods again, but there are actually some pretty compelling use cases for this feature: iterators and async methods.
```csharp
Task<int> UpdateSkill(string skill, int level)
{
    if (string.IsNullOrWhiteSpace(skill))
        throw new ArgumentException
            (message: "Skill name is required.");
    if (level < 1)
        throw new ArgumentOutOfRangeException
            (paramName: nameof(level), 
            message: "Level must be > 0.");
    return AsyncSkillUpdate();

    async Task<int> AsyncSkillUpdate()
    {
        var result = await ApplyLevel();
        return result.ID;
    }
}
```
***
[**4. Out Variables**](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#pattern-matching)
If you need to return multiple values from a method call, you can create a custom class as the return type, or you can use the out keyword. Using the out keyword causes arguments to be passed by reference. Out functions like the ref keyword, except when using out, you no longer have to initialize variables before they are passed in.
```csharp
class OutVariableDemo
if (int.TryParse(input, out var answer))
    Console.WriteLine(answer);
else
    Console.WriteLine("Could not parse input");
```
***
[**4. Tuples**](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#tuples-and-discards)
Essentially, tuples are a way to define simple structures that contain multiple data elements. You could use a class or a struct for this, but sometimes the effort to do so outweighs the benefit. Take the following example for unamed tuple:
```csharp
var FullName = ("Chris", "Williams");
```
Tuples, named or unnamed, make it significantly easier to work with statically typed data structures that contain multiple fields, but don't require any of the behaviors of classes and structs. Tuples work best with private and internal methods. Stick to user defined classes or structs for your public methods.
Despite what the previous examples would have you believe, you aren't limited to just two variables in a tuple. Also, under the hood, a tuple is essentially just a struct, and you can handle assignment pretty easily
***


### Version 8.O ###
- It is the first major C# release in 2019 that is specifically targets .NET Core.
- C# 8.0 is supported on .NET Core 3.x and .NET Standard 2.1.
- Its new features rely on new CLR capabilities, others on library types added only in .NET Core

**Key features and enhancements to the C# 8.O**
- **Indices and ranges** : Allow you to access single element or ranges in a sequence.

--Access element by index: The index from end operator **^**, which specifies that an index is relative to the end of the sequence.
--System.Range represents a sub range of a sequence.
--Acess element between specific range : The range operator **..**, which specifies the start and end of a range as its operands.
--*example* :
```
    int[] arr = new int[] {1,2,3,4,5};
    //indices 
    var ar = arr[^2];//access second last element
    //range 
    var ar1 = arr[..3]; //Start from 0th and goes before 3rd index
```
*** 
- **Readonly members** :  
    - In this feature, you are allowed to use a readonly modifier to any member of the structure. This readonly modifier specifies that the member is not allowed to modify. It is better than applying the whole structure readonly.
    - it is just like a const keyword i.e we doesn't modify the value of it ,only difference is that , in const we need to do initlalization and declaration on same time  , but in readonly we can do declaration later but only once.
    - example:
     ```
     const int num=100;
     int readonly pi ;
     pi=3.14;
     ```
     ***

- **Pattern matching** : Patterns are criteria which can be used to test if a value matches the desired pattern. Prior to C# 8, we already had patterns, one example of a  pattern is a switch statement where we use cases to match with.
  - *switch pattern* : It helps to use switch expression syntax with fewer case, break and curly braces.
    - The variable comes before the **switch** keyword. 
    - The case and : elements are replaced with **=>**. It's more concise and intuitive.
    - The default case is replaced with a **_** discard.
  - *Example* :
//
```
public enum trafficSignal
{
    Red,
    Yellow,
    Green
}
public static string signal(trafficSignal colorBand) =>
    colorBand switch
    {
        trafficSignal.Red    =>" Please Stop",
        trafficSignal.Yellow =>" Please slow down your speed",
        trafficSignal.Green  => "Go",
        _              =>  "invalid enum value",
    };
    
```
*** 

- **Enhancement of interpolated verbatim strings** :
 Order of the `$` and `@` tokens in interpolated verbatim strings can be any: both `$@"..."` and `@$"..."` are valid interpolated verbatim strings. 
 In earlier C# versions, the $ token must appear before the @ token.
 (@ symbol is to tell the string constructor to ignore escape characters and line breaks.)

```

var userName = "John";
var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
```
***

## Version 9.O ## 

- C# 9.0 was released with .NET 5.
- It's the default language version for any assembly that targets the .NET 5 release. 

**Key features and enhancements to the C# 8.O**

- **Top-level statements** :
   - Top-level statements remove unnecessary ceremony from many  applications.That means ui remove all the boilerplate around a class like using statements and a namespace.
   - * Example : 
        - normal statements:
        ```
        using System;
        namespace CSharp9
        {
            class Program
            {
                static void Main(string[] args)
                { Console.WriteLine("Hello World!");
                }
            }}
        ```

       -  new top-level statements
       ```
       System.Console.WriteLine("Hello World!");
        ```
        ***


- **Pattern matching enhancements** :
   - The pattern matching which was first introduced in C# 7 got new keywords. Now you can concatenate the check of your expression with not, and, and or.
   - * Example :
    ```
      private static void PatternMatchingEnhance(char Str){
      var isLetter = str is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') and not (>= '0' and <= '9');
      Console.WriteLine($"{str} is a letter and not a number: {isLetter}");
        }
    ```
    ***

- **Init only setters** : They allow you to set a value for a property when you create the object but then prohibit you from setting a new value for the property. 
   - syntax :  public int EmpId{ get; init};
    /*without using init  we can get and set value many times with obj ref  but with init we have to initialize the value only at the time of object creation , after that it is not allow to set the value again*/
    ```
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee(101, "XYZ"); //this will give an error

            Employee emp = new Employee
            {
                empId = 101, // initialize only once 
                empName = "XYZ"
            };

            // emp.empId = 102;//error
            emp.empName = "ABC";

            Console.WriteLine(emp.empId + " " + emp.empName);            
        }  
    }
 
    public class Employee
    {
        public int empId { get; init; }
        public string empName { get; set; }
    }
    ```
    ***


- **Records** : You use the record keyword to define a reference type that provides built-in functionality for encapsulating data. 
 Allow you to define a class with its properties and a constructor in one line.
 immutable - not changable
  - Example :
  ```
   class Program
    { Static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                empId = 101, 
                empName = "XYZ"
            };
            Console.WriteLine(emp.empId + " " + emp.empName);

            var emp1 = emp with { empId = 105, empName="Nikita" };
            
            emp.empName="Nikita";
            Console.WriteLine(emp1.empId + " " + emp.empName);
        } 
    }
    public record Employee
    {
        public int empId { get; init; }
        public string empName { get; init; }
    }
    ```
    ***   



