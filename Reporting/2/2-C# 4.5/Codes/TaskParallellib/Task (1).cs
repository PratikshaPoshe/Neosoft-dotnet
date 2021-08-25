using System;
using System.Threading;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("i= " + i);
                Thread.Sleep(1000);
            });
        }
    }
}
