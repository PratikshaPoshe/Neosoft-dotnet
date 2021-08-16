using System;

namespace demo
{
    abstract class Banks
    {
        protected decimal roi;
        internal abstract void detail(decimal roi);
        internal void printRoi(string name)
        {
            Console.WriteLine($"Rate of Interest for {name} is {roi}\n\n");
        }
    }

    class SBI : Banks
    {
        internal override void detail(decimal roi)          //removing override method will throw error and will force you to override the abstract method
        {
            base.roi = roi;
            base.printRoi("State Bank of India");
        }
    }
    class AXIS : Banks
    {
        internal override void detail(decimal roi)
        {
            base.roi = roi;
            printRoi("AXIS Bank");
        }
    }
    class HDFC : Banks
    {
        internal override void detail(decimal roi)
        {
            base.roi = roi;
            printRoi("HDFC Bank");
        }
    }

    class Pizza
    {
        internal static string type = "VEG";

    }

    class Pizzeria : Pizza
    {
        new internal static string type = "NON-VEG"; // removing new will throw warning and will suggest to use <new> keyword to hide pre-existing data
    }
    class ProgramN
    {
        static void Main(string[] args)
        {
            HDFC hdfcUser = new HDFC();
            hdfcUser.detail(8.8m);

            AXIS axisUser = new AXIS();
            axisUser.detail(7.3m);

            SBI sbiUser = new SBI();
            sbiUser.detail(6.2m);

            Console.WriteLine(Pizza.type);
            Console.WriteLine(Pizzeria.type);
        }
    }
}
