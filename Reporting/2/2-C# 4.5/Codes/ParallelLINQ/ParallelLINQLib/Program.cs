namespace Parallel_Lib
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        internal static void Main()
        {
            var sw = new Stopwatch();  // stopwatch -> Provides a set of methods and properties
                                       //that you can use to accurately measure elapsed time.
            while (true)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();//   Suspends the current thread until the thread that is processing the queue of
                                              //     finalizers has emptied that queue.
                GC.Collect();
                var tcs = new TaskCompletionSource<object>();
                var t = tcs.Task;
                sw.Restart();
                for (int i = 0; i < 1000000; i++)
                    t = t.ContinueWith(_ => (object)null);
                var elapsed = sw.Elapsed;
                GC.KeepAlive(tcs);
                Console.WriteLine(elapsed);
            }
        }
    }
}
