using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class XX
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }

    class Extension
    {
        public static void ExtensionCode()
        {
            Class1 ob = new Class1();
            ob.Display();
            ob.Print();
            ob.NewMethod();
        }
    }
}
