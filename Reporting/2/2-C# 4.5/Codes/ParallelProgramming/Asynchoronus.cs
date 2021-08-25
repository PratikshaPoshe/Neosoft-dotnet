using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Asynchoronus
    {
        public static async Task<List<int>> GetPrimeNumbersAsync(int minimum, int maximum)
        {
            var count = maximum - minimum + 1;
            List<int> result = new List<int>();

            return await Task.Factory.StartNew(() =>
            {
                for (int i = minimum; i <= maximum; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        result.Add(i);
                    }
                }
                return result;
            });
        }

        static bool IsPrimeNumber(int number)
        {
            if (number % 2 == 0)
            {
                return number == 2;
            }
            else
            {
                var topLimit = (int)Math.Sqrt(number);
                for (int i = 3; i <= topLimit; i += 2)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }
        }

    }
}
