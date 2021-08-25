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
            Console.WriteLine($"\tValue 1 = {val1}");
            Console.WriteLine($"\tValue 1 = {val2}");
            Console.WriteLine($"\tReturn value (comparison) = {val1.CompareTo(val2)}");

            string strFirst = "Firststring";
            string strSecond = "secondstring";
            string strThird = "thirdstring";
            string strFourth = "fourthstring";

            // Compare a string to itself.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFirst)));
            Console.WriteLine("\t" + (CompareStrings(strFirst, strSecond)));
            Console.WriteLine("\t" + (CompareStrings(strFirst, strThird)));

            // Compare a string to another string that varies only by case.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFourth)));
            Console.WriteLine("\t" + (CompareStrings(strFourth, strFirst)));

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

        }
    }
}



