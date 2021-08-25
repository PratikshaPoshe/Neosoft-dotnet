### Assembly
Assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. According to microsoft it is a small unit of deployment. 

##### Assemblies take two forms
1. .exe(executable) - Basically compilation of application is .exe. It is the main executable file which contains the Main function.
2. .dll(dynamic link library)-Basically compilation of class library is .dll. It is a module that contains functions and data that can be used by another module. The purpose of dll is reusabilty.

* The important point of assemblies is that, it provides CLR(Common Language runtime)

##### Types of assembly
    
* Private : Requires to copied separately in all application folder.
* Public : Need not required to be copied as only one copy is required at system.
*  Satellite : Are used for deployment of language and culture specific resources. 

* Key features or properties of assemblies
    -It can be implemented as .exe or .dll
    -Loaded into memory when needed.
    -Information about assembly can be found using reflection.
    -Can share assembly between applications using GAC(Global Assembly Cache). 



### Namespace 
- Namespaces are used to organize the classes. It helps to control the scope of methods and classes in larger .Net programming projects.
- In simpler words we can say that it provides a way to keep one set of names(like class names) different from other sets of names.
- The biggest advantage of using namespace is that the class names which are declared in one namespace will not clash with the same class names declared in another namespace.
``` C#
// namespace declaration
namespace first { 
    class Example_1 
    {    
        public static void display()
        {
            // Here System is the namespace
            // under which Console class is defined
            System.Console.WriteLine("Hello Geeks!");
  
        }
    }    
} // ending of first namespace
  
class Example_2
{    
    public static void Main(String []args)
    {
        first.Example_1.display();              
    } 
} 
```
#### Difference
| Namespace        | Assembly           | 
| :--------------: |:-------------:| 
| System.Data is a namespace.  | System.Data.DLL is an assembly. | 
| Logical division of classes in .NET framework  | Fundamental unit of deployment, version control, reuse ,activation scoping and security permissions for a .NET based application. | 
| Namespace contains set of unique names.  | Assembly contains code of the form MSIL ( Microsoft Intermediate Language) |
| Classes available in your program will be logically grouped together under a namespace.  | Logical units are physically grouped together as assembly. |  
| Provides a fundamental unit of logical code grouping.      | Provides a fundamental unit of physical code grouping.      | 
| Namespaces can be nested. For ex: namespace sampleApp1 {namespace sampleApp2{class sampleClass{..} } }    | Such nesting is not permissible in assemblies.      | 
| Namespaces have to be mentioned in Project-Properties.    | Assemblies need not be explicitly specified. They are automatically described in metadata and manifest files.      | 
| Namespace doesn't have any classification.  | Assembly can be classified as private assembly and public assembly. Private assembly is specific to a single application but shared/public assembly contains libraries which can be used by multiple applications.     | 