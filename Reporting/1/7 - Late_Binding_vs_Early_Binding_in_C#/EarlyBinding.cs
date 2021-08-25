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
            // creating object of Binding class
            Binding binding = new Binding();

            // Calling the method of Binding class
            binding.details("Himani", "C#");

            // Calling "mymethod()" gives error
            // because this method does not
            // belong to class Binding or compiler
            // does not know mymethod() at compile time
            binding.mymethod();


        }
    }
}
