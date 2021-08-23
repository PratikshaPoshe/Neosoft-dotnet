using System;
namespace MiscelleaneousTopics
{
    public delegate double DelArea(double dimension);//declare a user defined delegate
    public class Shape
    {
        /// <summary>
        /// Anonymous method
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static DelArea delSqArea = delegate(double length){
            Console.WriteLine($"Square Area with dimension {length}cm is {length*length} cm2");
            return length*length;
        };
        /// <summary>
        /// Lambda expressions
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static Func<double,double> delCircleArea = (double radius) => Math.PI*radius*radius;        
    }
}