using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   // Example of comparison using == operator.
            Console.WriteLine("Using == operator :\n");
             int a = 3, b = 4, c=7;
            int com = a + b;
            if (com == c) Console.WriteLine("\t Both the variables contain same value.");
            else Console.WriteLine("\t Both the variables do not contain same value.");


            // Example of comparison using Equals() method.
            Console.WriteLine("\nUsing Equals() :\n");
            object o = ".NET";
            object o1 = o;
            
            Console.WriteLine("\t"+(o == o1 )+ ": is the value returned by == operator .");
            Console.WriteLine("\t" + o.Equals(o1) + ": is the value returned by Equals() .");
            


            // Example of comparison using ReferenceEquals() method. 
            Console.WriteLine("\nUsing ReferenceEquals() :\n");
            object n = null;
            object p = null;
            object q = new Object();

            Console.WriteLine("\t" + (Object.ReferenceEquals(n, p)));//true
            p = q;
            Console.WriteLine("\t" + (Object.ReferenceEquals(p, q)));//true  


            // Example of comparison using CompareTo() method. 
            Console.WriteLine("\nUsing CompareTo() :\n");
            int val1 = 10;
            int val2 = 10;
            int val3 = 11;
            int val4 = 13;
            Console.WriteLine($"Value 1 = {val1}");
            Console.WriteLine($"Value 2 = {val2}");
            Console.WriteLine($"Value 3 = {val3}");
            Console.WriteLine($"Value 4 = {val4}");

            Console.WriteLine("\t" + (CompareValue(val1, val2)));
            Console.WriteLine("\t" + (CompareValue(val1, val3)));
            Console.WriteLine("\t" + (CompareValue(val4, val3)));


            string strFirst = "Firststring";
            string strSecond = "Secondstring";
            string strThird = "thirdstring";
            string strFourth = "fourthstring";

            // Compare a string to itself.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFirst)));

            Console.WriteLine("\t" + (CompareStrings(strFirst, strSecond)));
            Console.WriteLine("\t" + (CompareStrings(strFirst, strThird)));

            // Compare a string to another string that varies only by case.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFourth)));
            Console.WriteLine("\t" + (CompareStrings(strFourth, strFirst)));

        }

        static string CompareStrings(string str1, string str2)
        {
            // Compare the values, using the CompareTo method on the first string.
            int cmpVal = str1.CompareTo(str2);

            if (cmpVal == 0) // The strings are the same.
                return "The strings occur in the same position in the sort order.";
            else if (cmpVal < 0)
                return "The first string precedes the second in the sort order.";
            else
                return "The first string follows the second in the sort order.";
        }

        static string CompareValue(int val1, int val2)
        {
            // Compare the values, using the CompareTo method on integer value
            int objVal = val1.CompareTo(val2);

            if (objVal == 0) // The values are same.
                return ($" {val1} and {val2}");
            else if (objVal < 0)
                return ($" {val1} is less than {val2}");
            else
                return ($" {val1} is greater than {val2}");
        }
        
    }
}



