using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Generics2<T>
    {
        public bool Compare(T i, T j)
        {
            if (i.Equals(j))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
