using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Partial Types---------------\n");
            Student_partial obj = new Student_partial();
            obj.Firstname = "Jaideep";
            obj.Lastname = " sahu";
            Console.WriteLine("My full name is :" + obj.Getcomplete());

            Console.WriteLine("\n-------------Iterators---------------\n");

            IEnumerable<string> my_slist = Iterator.GetMyList();
            foreach (var i in my_slist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n-------------Generics---------------\n");
            Generics1 g1 = new Generics1();
            Console.WriteLine(g1.Compare("A","B"));

            Generics2<int> g2 = new Generics2<int>();
            Console.WriteLine(g2.Compare(1,2));

            Generics2<string> g3 = new Generics2<string>();
            Console.WriteLine(g3.Compare("Pranali", "Pranali"));

            

            Console.ReadLine();
        }
    }
}
