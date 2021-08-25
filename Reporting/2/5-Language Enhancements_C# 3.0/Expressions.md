# Lambda Expressions
- You use a lambda expression to create an anonymous function. Use the lambda declaration operator => to separate the lambda's parameter list from its body. 
-  A lambda expression can be of any of the following two forms:
   1) Expression lambda that has an expression as its body:  
   ``` (input-parameters) => expression ```
   2) Statement lambda that has a statement block as its body:  
   ``` (input-parameters) => { <sequence-of-statements> }``` 
- To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator and an expression or a statement block on the other side.
```
x => x+x;
```
- ***Any lambda expression can be converted to a delegate type.***

  1) If a lambda expression doesn't return a value, it can be converted to one of the Action delegate types.
  2) otherwise, it can be converted to one of the Func delegate types.

```
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));
// Output:
// 25

Action<int> square = x => Console.WriteLine(x * x);
square(5);
// Output:
// 25
 ```

## Query Expressions
**What is a query and what does it do?**
- A query is a set of instructions that describes what data to retrieve from a given data source (or sources) and what shape and organization the returned data should have.

<p>&nbsp;</p>

**What is a query expression?**
- A query expression is a query expressed in query syntax. 
- A query expression is a first-class language construct. It is just like any other expression and can be used in any context in which a C# expression is valid. 
- A query expression consists of a set of clauses written in a declarative syntax similar to SQL or XQuery. 
- Each clause in turn contains one or more C# expressions, and these expressions may themselves be either a query expression or contain a query expression.

- A query expression must begin with a from clause and must end with a select or group clause. 
- Between the first from clause and the last select or group clause, it can contain one or more of these optional clauses: where, orderby, join, let and even additional from clauses. 
- You can also use the into keyword to enable the result of a join or group clause to serve as the source for additional query clauses in the same query expression.
<p>&nbsp;</p>

**Query variable**
- In LINQ, a query variable is any variable that stores a query instead of the results of a query. 
- More specifically, a query variable is always an enumerable type that will produce a sequence of elements when it is iterated over in a foreach statement or a direct call to its IEnumerator.MoveNext method.

The following code example shows a simple query expression with one data source, one filtering clause, one ordering clause, and no transformation of the source elements. The select clause ends the query.
<p>&nbsp;</p>

```C#
static void Main()
{
    // Data source.
    int[] scores = { 90, 71, 82, 93, 75, 82 };

    // Query Expression.
    IEnumerable<int> scoreQuery = //query variable
        from score in scores //required
        where score > 80 // optional
        orderby score descending // optional
        select score; //must end with select or group

    // Execute the query to produce the results
    foreach (int testScore in scoreQuery) //testscore is the range variable
    {
        Console.WriteLine(testScore);
    }
}
// Outputs: 93 90 82 82
```

<p>&nbsp;</p>

- A **query expression** must begin with a from clause. 
- It specifies a data source together with a range variable. 
- The range variable represents each successive element in the source sequence as the source sequence is being traversed. 
- The range variable is strongly typed based on the type of elements in the data source. 
- The range variable is in scope until the query is exited either with a semicolon or with a continuation clause.
- A query expression may contain multiple from clauses. 
<p>&nbsp;</p>

**Ending a query expression**
- A query expression must end with either a group clause or a select clause.


**group clause**
- Use the group clause to produce a sequence of groups organized by a key that you specify. 
- The key can be any data type. For example, the following query creates a sequence of groups that contains one or more Country objects and whose key is a char type with value being the first letter of countries' names.

```C#
var queryCountryGroups =
    from country in countries
    group country by country.Name[0];
```

**select clause**
- Use the select clause to produce all other types of sequences. 
- A simple select clause just produces a sequence of the same type of objects as the objects that are contained in the data source. 
- In this example, the data source contains Country objects. 
- The orderby clause just sorts the elements into a new order and the select clause produces a sequence of the reordered Country objects.

```C#
IEnumerable<Country> sortedQuery =
    from country in countries
    orderby country.Area
    select country;
```
<p>&nbsp;</p>


**Filtering, ordering, and joining**
- Between the starting from clause, and the ending select or group clause, all other clauses (where, join, orderby, from, let) are optional. 
- Any of the optional clauses may be used zero times or multiple times in a query body.

    **where clause**
    - Use the where clause to filter out elements from the source data based on one or more predicate expressions. 
    - The where clause in the following example has one predicate with two conditions.
    <p>&nbsp;</p>

    ```C#
    IEnumerable<City> queryCityPop =
        from city in cities
        where city.Population < 200000 && city.Population > 100000
        select city;
    ```

    **orderby clause**
    - Use the orderby clause to sort the results in either ascending or descending order. 
    - You can also specify secondary sort orders. 
    - The following example performs a primary sort on the country objects by using the Area property. 
    - It then performs a secondary sort by using the Population property.
    <p>&nbsp;</p>

    ```C#
    IEnumerable<Country> querySortedCountries =
        from country in countries
        orderby country.Area, country.Population descending
        select country;
    ```

    **join clause**
    - Use the join clause to associate and/or combine elements from one data source with elements from another data source based on an equality comparison between specified keys in each element. 
    - After you have joined two sequences, you must use a select or group statement to specify which element to store in the output sequence. 
    - You can also use an anonymous type to combine properties from each set of associated elements into a new type for the output sequence. 
    - The following example associates prod objects whose Category property matches one of the categories in the categories string array. 
    - Products whose Category does not match any string in categories are filtered out. The select statement projects a new type whose properties are taken from both cat and prod.
    <p>&nbsp;</p>

    ```C#
    var categoryQuery =
        from cat in categories
        join prod in products on cat equals prod.Category
        select new { Category = cat, Name = prod.Name };
    ```


    **let clause**
    - Use the let clause to store the result of an expression, such as a method call, in a new range variable. 
    <p>&nbsp;</p>

    ```C#
    string[] names = { "Svetlana Omelchenko", "Claire O'Donnell", "Sven Mortensen", "Cesar Garcia" };
    IEnumerable<string> queryFirstNames =
        from name in names
        let firstName = name.Split(' ')[0]
        select firstName;

    foreach (string s in queryFirstNames)
        Console.Write(s + " ");
    //Output: Svetlana Claire Sven Cesar
    ```


# Expression Trees :  
An Expression Tree is a data structure that defines code. They are based on the same structures that a compiler uses to analyze code and generate the compiled output. 
- Expression trees represent code in a tree-like data structure, where each node is an expression 
- Expression tree as name suggests is nothing but expressions arranged in a tree-like data structure.  
- For example, an expression tree can be used to represent mathematical formula x < y where x, < and y will be represented as an expression and arranged in the tree like structure.  
  
Expression tree is an in-memory representation of a lambda expression. It holds the actual elements of the query, not the result of the query.  
Only expression trees that represent lambda expressions can be executed.  
  
``` C# 
var sum = 2 + 10;
```  
- Variable declaration statement with assignment `(var sum = 2 + 12)`  
  - Implicit variable type declaration `(var sum)`  
    - Implicit var keyword `(var)`  
    - Variable name declaration `(sum)`  
  - Assignment operator `(=)`  
  - Binary addition expression `(2+12)`  
    - Left operand `(2)`
    - Addition oparand  `(+)`
    - Right oparand `(12)`  
  
**Expression trees are immutable**. Being immutable means that you must build the tree from the leaves up to the root. 
  
## Creating Expression tree:  
Example-1:
```c#
 
		//Expression<Func<int>> sum = () => 10 + 2;

		// creating parameter expressions for num:
		var s1 = Expression.Constant(10, typeof(int));

		// creating constant expressions for 5:
		var s2 = Expression.Constant(2, typeof(int));

		//Creating a method call expression for the call to GreaterThan
		var addition = Expression.Add(s1, s2);


		//  then finally, put the method call into a lambda expression, and define the arguments to the lambda expression:
		var lambda = Expression.Lambda<Func<int>>(addition);
```
  
To create expression trees one should use Expression class.  
Every lambda expression cannot be implicitly converted into an expression tree. Only expression lambda is implicitly converted to an expression tree and statement lambda i.e. multi-line lambda cannot be implicitly converted into expression tree.
    


   