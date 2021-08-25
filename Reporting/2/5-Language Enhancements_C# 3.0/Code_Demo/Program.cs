using System;

namespace Topic2Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            LambaDemo obj = new LambaDemo();
            obj.square(5);

            int res = obj.cube(3);
            Console.WriteLine("cube = "+res);

            obj.greet("Aman");

            // Console.WriteLine("\n Expressions Tree Demo");
            // ExpressionTree expObj = new ExpressionTree();

            // Console.WriteLine("\n Query Demo");
            //QueryDemo obj1 = new QueryDemo();
            //obj1.ShowDemo();
        }
    }
}
