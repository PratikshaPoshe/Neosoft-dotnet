using System;
using System.Threading;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i= " + i);
                Thread.Sleep(1000);
            }
        }
    }
}