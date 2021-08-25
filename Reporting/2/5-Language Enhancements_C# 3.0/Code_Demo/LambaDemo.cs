using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic2Expressions
{
    public class LambaDemo
    {

        public Action<int> square = x => Console.WriteLine("Square = "+x * x);
        
        //expression lambda
        //returns implicitly
        public Func<int, int> cube = x => x * x * x;

        // statement lambda
        //will not return implicitly
        public Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
    }
}
