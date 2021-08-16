## Why we Use Ref And Out ?
-   When we want to return more than one output from a method
-   Or we want to modify a parameter and return back that modified parameter to the caller
-   Generally, when we pass parameter to a method, they are passed by value but when we use ref and out parameter, the parameters are passed by reference.

------------------------------------------------------------------------------------
### Passing Arguments to Method by Value. 
``` C#
Static void SomeFunction(int InsideVar)  
{  
     InsideVar=InsideVar+10;  
}               

Static void Main(string[] args)  
{  
     int outSideVar=20;  
     SomeFunction(outSideVar);  
     Console.WriteLine(outSideVar);      //20
}  
```
- By default, when we pass variables to methods or functions,it is passed by value.
- We are trying to manupulate the variable InsideVar by adding 10 to InsideVar.After running the code the value is stil 20.This means, Whatever changes happened inside the method is not effected outside.

------------------------------------------------------------------------------------------ 
### Passing Arguments to Method by Reference (ref).
``` c#
 Static void SomeFunction(ref int InsideVar)  
 {  
     InsideVar=InsideVar+10;  
 }  
 Static void Main(string[] args)  
 {  
     int outSideVar=20;  
     SomeFunction(ref outSideVar);  
     Console.WriteLine(outSideVar);        //30  
 }  
```
- The ref keyword indicates that an argument is passed by reference, not by value.
- It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.
- To use a ref parameter, both the method definition and the calling method must explicitly use the ref keyword.
- By using ref keyword, we are manupulated the value inside the method, and the ouside variable value is also manupulated.
- When outside value is passed to a method, its not only passed the data,it passes the reference.    
-----------
### Passing Arguments to Method by Reference (out).  
``` c#
Static void SomeFunction(out int InsideVar)  
 {  
    InsideVar=0;  
    InsideVar=InsideVar+10;  
 }  

 Static void Main(string[] args)  
 {  
    int outSideVar=20;  
    SomeFunction(out outSideVar);  
    Console.WriteLine(outSideVar);          //10
 }
 ```
- In out, its mandatory to initialize the variable inside the callee method. In out variabl passes the address only from caller to the callee and only manupulated data will goes to the caller.
--------


| ref | out |
|:-----:|:-----:|
|  - Requires the passed parameter to be initilized before passing |  - Doesn't require passed parameter to be initilized |
|  - It's not must to assign a value to passed ref parameter inside the method |  - It is must to assign a value to passed out parameter inside the method|
|  - It may or may not modify the value |  - It definitely modifies the value |
|  - Method can read the value of the passed parameter. |  - It doesn't read the value and considers the parameter as unassigned. |  

**Ref and out both have the same implementation, the only difference is how the compiler tracks wheather variables are assigned or not.**

--------
### ref/out keyword & method Overloading.
- Both ref and out are treated differently at run time and they are treated the same at compile time, so methods cannot be overloaded if one method takes an argument as ref and the other takes an argument as an out.  

**Code**
``` c#
public static string GetNextName(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
public static string GetNextName(out int id)
{
    id = 1;
    string returnText = "Next-" + id.ToString();
    return returnText;
}
```
**Output**
Cannot define overloaded method 'GetNextName' because it differs from another method only on ref and out.  
**Solution**
- However, method overloading can be possible when one method takes a ref or out argument and the other takes the same argument without ref or out.
**Code**
``` c#
public static string GetNextName(int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
public static string GetNextName(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
```
**The out and ref keywords are useful when we want to return a value in the same variables that are passed as an argument.**