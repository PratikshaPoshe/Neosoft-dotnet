using System;

namespace ConsoleApp1
{
    class Details
    {
        public void showDetails()
        {
            var i = 100;
            Console.WriteLine(i.GetType());

            var x = "Akshay";
            Console.WriteLine(x.GetType());

            var y = 12.5;
            Console.WriteLine(y.GetType());

            var z = true;
            Console.WriteLine(z.GetType());
        }
    }
    class Program
    {
        //var id;
        static void Main(string[] args)
        {
            Details d = new Details();
            //d.showDetails();


            // var variables must be initialized..
            int i;
            i = 10;
            Console.WriteLine(i);

            //var x;
            //x = 10;
            //Console.WriteLine(x);

            //Multiple declarations..
            int a = 10, b = 30;
            Console.WriteLine(a+" "+b);

            //var a = 10, b = 30;
            //Console.WriteLine(a + " " + b);

            //Collection Initializer code
            //ObjectInitializer.ColCode();

            //Extension code..
            //Extension.ExtensionCode();




        }
    }
}
