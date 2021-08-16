
![image](Early-binding-and-Late-binding-in-C.png)

# Late Binding

<br/>

   ### What is Late Binding ?
   1.  Objects are dynamic objects
   2.  Achieved by using virtual methods
   3.  Performance : slow as compared to the early binding
   4.  Executes at the Run time
   5.  Variables declared by using dynamic can be an example of late binding.Because type of the variable is decided by the compiler at runtime.
   
   <br/>


### Example for Late Binding:
Common Examples:

`Object objItems;`

`objItems = CreateObject("DLL or Assembly name");`

    Here during the compile time, type of objItems is not determined. We are creating an object of a dll and assigning it to the objItems, so everything is determined at the run time.

   <br/>

   #### Code for Late Binding

```
// concept of late binding
using System;

namespace LateBinding_Vs_EarlyBinding
{
    class LateBinding
    {
        static void Main(string[] args)
        {
            // Dynamic objects
            dynamic obj = 4;
            dynamic obj1 = 5.678;

            // Display the type of objects
            Console.WriteLine("The type of the objects are :");

            // GetType() method is 
            // used to get the type
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj1.GetType());
        }
    }
}

```
<br/>

<br/>
<br/>
<br/>

# Early Binding

<br/>

   ### What is Early Binding ?
   1. The compiler knows about what kind of object it is, what are all the methods and properties it contains.
   2. It recognizes and checks the methods, or properties  during compile time.
   3. The performance of early binding is fast and it is easy to code.
   4. It decreases the number of run-time errors.
   5. Variables declared by using var can be an example of early binding.Because type of the variable is decided by the compiler at compile time.

 <br/>

### Example for Early Binding

Common Examples:

- ComboBox cboItems;

- ListBox lstItems;
  
    In the above examples, if we type the cboItem and place a dot followed by, it will automatically populate all the methods, events and properties of a combo box, because compiler already know it's an combobox.

 <br/>

   #### Code for Early Binding

   ```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBinding_Vs_EarlyBinding
{
    /* concept of early binding */
    public class Binding
    {
        // data members
        public string name;
        public string subject;

        // public method
        public void details(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }
    
    /* Driver Class */
    class EarlyBinding
    {
        static void Main(string[] args)
        {
            // creating object of Geeks class
            Binding binding = new Binding();

            // Calling the method of Geeks class
            binding.details("Himani", "C#");

            // Calling "mymethod()" gives error
            // because this method does not
            // belong to class Binding or compiler
            // does not know mymethod() at compile time
            binding.mymethod();


        }
    }
}

   ```


<br/>
<br/>


<br/>
<br/>

### Difference Between Late Binding Vs Early Binding

|Early Binding|Late Binding|
|------------|-------------|
|It is a compile-time process|It is a run-time process|
|Early Binding is also known as static binding.| Late Binding is also known as dynamic binding.|
|The method definition and method call are linked during the compile time.|The method definition and method call are linked during the run time.|
|Actual object is not used for binding.|Actual object is used for binding.|
|For example: Method overloading|For example: Method overriding|
|Program execution is faster|Program execution is slower|

<br/><br/>

![diff image](https://www.bestprog.net/wp-content/uploads/2020/04/02_02_02_11_09_01e-1024x603.jpg)
<br/>
<br/>
<br/>

### Summary

OOP is used commonly for software development. One major pillar of OOP is polymorphism. Early Binding and Late Binding are related to that. Early Binding occurs at compile time while Late Binding occurs at runtime. In method overloading, the bonding happens using the early binding. In method overriding, the bonding happens using the late binding. The difference between Early and Late Binding is that Early Binding uses the class information to resolve method calling while Late Binding uses the object to resolve method calling.