using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            nullConditional N = new nullConditional();
            exceptionFilter expt = new exceptionFilter();
            ExpressionBodied expr = new ExpressionBodied();

            /*if(N.Name != null)
            {
                Console.WriteLine(N.Name);
            }
            else
            {
                Console.WriteLine("Name is null");
            }*/

           // var name = N?.Name ?? "Name is Null";
            //Console.WriteLine(name);

            expt.exFilter();
            expr.add();
            Console.WriteLine("The addition is:"+expr.Num3);

            Console.ReadLine();
        }
    }
}
