using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Parallel_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var cd = new ConcurrentDictionary<int, int>();
                var sw = Stopwatch.StartNew();  // stopwatch ->Provides a set of methods and properties
                                                // that you can use to accurately measure elapsed time.
                                                //startNew -> Creates and starts a task for the specified action.
                cd.TryAdd(42, 0);
                for (int i = 1; i < 10000000; i++)
                {
                    cd.TryUpdate(42, i, i - 1);
                }
                Console.WriteLine(sw.Elapsed); //Gets the total elapsed time measured by the current instance.
            }
        }
    }

}
