using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int outSideVar = 20;
            Value.SomeFunction(outSideVar);
            Console.WriteLine("Passing Argument to Method by Value : "+outSideVar);

            //Using ref
            refs.SomeFunction(ref outSideVar);
            Console.WriteLine("Passing Argument to Method Using ref : "+outSideVar);

            //Using out
            outs.SomeFunction(out outSideVar);
            Console.WriteLine("Passing Argument to Method Using ref: "+outSideVar);
        }
    }
}
