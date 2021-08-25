using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class outs
    {
        public static void SomeFunction(out int InsideVar)
        {
            InsideVar = 0;
            InsideVar = InsideVar + 10;
        }
    }
}
