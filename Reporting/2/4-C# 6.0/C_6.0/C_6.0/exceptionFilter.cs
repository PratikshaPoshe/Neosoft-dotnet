using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6._0
{
    class exceptionFilter
    {
        public void exFilter()
        {
            int val1 = 0;
            int val2 = 0;
            try
            {
                Console.WriteLine("Enter first value :");
                val1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Next value :");
                val2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Div : {0}", (val1 / val2));
            }
            catch (Exception ex) when (ex.GetType().ToString() == "System.DivideByZeroException")
            {
                Console.WriteLine("Can't be Divided by zero ☺");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
