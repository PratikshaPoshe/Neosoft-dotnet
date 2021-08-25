using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Topic2Expressions
{
    class ExpressionTree
    {
		public ExpressionTree()
		{
			// Example-1:
			// num => num > 5 
			//creating parameter expressions for num:
			ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

			//creating constant expressions for 10:
			ConstantExpression five = Expression.Constant(5, typeof(int));

			// Creating Binary Expression i.e num > 5 
			BinaryExpression numLessThanFive = Expression.GreaterThan(numParam, five);

			// then finally, put the method call into a lambda expression, and define the arguments to the lambda expression:
			var lambda1 =
				Expression.Lambda<Func<int, bool>>(
					numLessThanFive,
					numParam);

			var r = lambda1.Compile()(3);

			Console.WriteLine(numLessThanFive);
			Console.WriteLine(lambda1);
			Console.WriteLine(r);

			//Example-2:
			//Expression<Func<int>> sum = () => 10 + 2;

			// creating constant expressions for 10:
			var s1 = Expression.Constant(10, typeof(int));

			// creating constant expressions for 2:
			var s2 = Expression.Constant(2, typeof(int));

			//Creating a method call expression for the call to Add
			var addition = Expression.Add(s1, s2);


			//  then finally, put the method call into a lambda expression:
			var lambda = Expression.Lambda<Func<int>>(addition);


			var result = lambda.Compile()();

			// Console.WriteLine(lambda);
			// Console.WriteLine(result);



			//Example- 3: 
			// Expression<Func<double, double, double>> distanceCal = (x, y) => Math.Sqrt(x * x + y * y);

			// creating parameter expressions for x and y:

			var parameterX = Expression.Parameter(typeof(double), "x");
			var parameterY = Expression.Parameter(typeof(double), "y");

			//Creating the multiplication and addition expressions
			var xSquared = Expression.Multiply(parameterX, parameterX);
			var ySquared = Expression.Multiply(parameterY, parameterY);
			var sum1 = Expression.Add(xSquared, ySquared);

			// Creating a method call expression for the call to Math.Sqrt 
			var sqrtMethod = typeof(Math).GetMethod("Sqrt", new[] { typeof(double) });
			var distance = Expression.Call(sqrtMethod, sum1);

			//  then finally, put the method call into a lambda expression, and define the arguments to the lambda expression:

			var distanceLambda = Expression.Lambda<Func<double, double, double>>(
					distance,
					 parameterX,
					parameterY);
			var res = distanceLambda.Compile()(1, 2);

			//Console.WriteLine(distanceLambda);
			//Console.WriteLine(res);
		}
	}
}
