using System;

namespace Protected_Costructors
{
    class Test
    {
        protected int _x = 12; private int _y;
    }
    class Test1 : Test
    {
        public Test1()
        {
            // In this we can  access the variable protected int but we cannot access private int variable
            Console.WriteLine(this._x);
        }
    }
    //class Test2
    //{
    //    public Test2()
    //    {
    //        Console.WriteLine(this._x);
    //    }
    //}
    class Program
    {
        static void Main()
        { Test1 b = new Test1();
            //Test2 b1 = new Test2();


        }
    }
}
