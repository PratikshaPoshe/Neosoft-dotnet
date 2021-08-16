using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class refs
    {
        public static void SomeFunction(ref int InsideVar)
        {
            InsideVar = InsideVar + 10;
        }
    }
}
