# _KEYWORDS  ( this , base , readonly , const)_

**1.base**

>Now there are two important scenarios that requires the use of base keyword:-

1)To access the **overriding method** of parent class whithin the overridden method of the child class. _(It resembles with the super keyword that we used to use in java to access the immediate parent classes members)._
Now i'll not go into the depth of super keyword as for now topic of focus is base keyword.

2)The second **very important** purpose of the base keyword is that it enables you to access parent classes constructor from within the child class constructor.
So whenever we create object of child class, Behind the scenes the child class constructor calls the parent class constructor implicitly.
Now , if the parent contructor is without any parameters i.e it is parameter less, then calling it from the child class constructor wil work all cool. It will create no problem.

3)But the problem arises when the parent class constructor turns out to be parameterized .Always remember that parametrized constructors are called explicitly for the very fact that we require to pass arguments to the parameters while calling it.

4)So, the base keyword enables us to call a parametrized parent class constructor from whithin the child class. All you have to do is put a colon sign immediately after the child constructor and use the base keyword put parenthesis and mention the arguments that you wanna pass to the parameters of the parent class constructor.

**2.const**

>A variable whose value can not be changed during the execution of the program is called a constant variable.

Constants are of two types
- Compile time constants (const)
- Runtime constants (Readonly)

1)The value can not be changed during execution of the program, which means we cannot assign values to the constant variable at run time. 
Instead, it must be assigned at the compile time.

>Constants are declared by using the const keyword
Syntax -> int const a=10;

2)Some key points about const variable - 
1. It must be assigned a value at the time of declaration.
	eg.	int const a=10;  

2. const only allow constant variables into the expression.

3. const can be declared at the class level as well as inside the method.

4. const can not be declared using static keyword because they are by default static.

>_When to use const?
The const is used when its value is absolutely constant. Such as PI value which cannot be changed._

**3.readonly (C# Reference)**: 

>The readonly keyword is a modifier that can be used in four contexts: 

1)In a field declaration, readonly indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class. A readonly field can be assigned and reassigned multiple times within the field declaration and constructor. 

2)A readonly field can't be assigned after the constructor exits. \
**This rule has different implications for value types and reference types:** 

- **Because value types directly contain their data, a field that is a readonly value type is immutable.**

- **Because reference types contain a reference to their data, a field that is a readonly reference type must always refer to the same object. That object isn't immutable.**

3)The readonly modifier prevents the field from being replaced by a different instance of the reference type. However, the modifier doesn't prevent the instance data of the field from being modified through the read-only field. 

4)In a readonly struct type definition, readonly indicates that the structure type is immutable. For more information, see the readonly struct section of the Structure types article. 

5)In an instance member declaration within a structure type, readonly indicates that an instance member doesn't modify the state of the structure. For more information, see the readonly instance members section of the Structure types article. 

6)In a ref readonly method return, the readonly modifier indicates that method returns a reference and writes aren't allowed to that reference. 

7)You can assign a value to a readonly field only in the following contexts: 

When the variable is initialized in the declaration, 

for example: 

C#Copy 

>public readonly int y = 5;  

8)In an instance constructor of the class that contains the instance field declaration. 

9)In the static constructor of the class that contains the static field declaration. 

_These constructor contexts are also the only contexts in which it's valid to pass a readonly field as an out or ref parameter._

5.this

>**_this keyword is used to refer to the current instance of the class._**


It is used to access members from the constructors, instance methods, and instance 
accessors. this keyword is also used to track the instance which is invoked to 
perform some calculation or further processing related to that instance. 

- Following are the different ways to use ‘this’ keyword in C# :

1. Using ‘this’ keyword to refer current class instance members

2. Using this() to invoke the constructor in same class

3. Using ‘this’ keyword to invoke current class method

4. Using ‘this’ keyword as method parameter

5. Using this keyword to declare an indexer


