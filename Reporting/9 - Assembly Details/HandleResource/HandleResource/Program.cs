using System;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;

namespace HandleResource
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;
            string year;
            string holiday;
            string celebrate = "{0} will occur on {1} in {2}.\n";
            ResourceManager rm = new ResourceManager("HandleResource.lang",
                             Assembly.GetExecutingAssembly());
            //CultureInfo ci = new CultureInfo("en-IN");        // **mark1** Instead of mark2 this can be used but need to pass ci as second argument in GetString() method
            Console.WriteLine("Obtain resources using the current UI culture.");
            //Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);        //for displaying culture before setting i.e defualt.
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-MX"); // **mark2**
            //Console.WriteLine(Thread.CurrentThread.CurrentUICulture.Name);        //for displaying culture after setting.

            //In mark1 and mark2 if invalid lang is passed then lang.resx will get executed
            day = rm.GetString("day");
            year = rm.GetString("year");
            holiday = rm.GetString("holiday");
            Console.WriteLine(celebrate, holiday, day, year);
        }
    }
}
