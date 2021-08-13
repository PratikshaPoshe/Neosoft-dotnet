using System;

namespace Contra_variance
{
   delegate Small covarDel(Big mc);

   public class Small
    {   
    }
    public class Big: Small
    {
    }
    public class Bigger : Big
    { 
    }

    class Program
    {
        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");
            return new Small();
        }
        static void Main(string[] args)
        {
            covarDel del = Method1;
            del += Method2;
            del += Method3;

            Small sm = del(new Big());
        }
    }
}
