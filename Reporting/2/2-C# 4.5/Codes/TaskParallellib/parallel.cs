using System;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => DoWork(1, 1000));
            t1.Start();
            var t2 = new Task(() => DoWork(2, 3000));
            t2.Start();
            var t3 = new Task(() => DoWork(3, 1500));
            t3.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
        static void DoWork(int id,  int sleep)
        {
            Console.WriteLine("Task {0} is beginning...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is Completed...", id);

        }
    }
}

