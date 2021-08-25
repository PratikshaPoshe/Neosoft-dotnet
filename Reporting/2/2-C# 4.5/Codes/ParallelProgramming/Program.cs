using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;


namespace ParallelProgramming
{
    class Program
    {
        public void getSync()
        {
            var sw = new Stopwatch();
            sw.Start();
            var primes = Synchronous.GetPrimeNumbers(2, 10000000);
            Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", primes.Count, sw.ElapsedMilliseconds);
        }
        public void getParallel()
        {
            var sw = new Stopwatch();
            sw.Start();
            const int numParts = 5;
            var primes = new List<int>[numParts];
            Parallel.For(0, numParts, i => primes[i] = ParallelProgramming.GetPrimeNumbers(i == 0 ? 2 : i * 1000000 + 1, (i + 1) * 1000000));
            var result = primes.Sum(p => p.Count);
            Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", result, sw.ElapsedMilliseconds);
        }
        /* static void Main(string[] args)
         {
             Program p1 = new Program();
             //p1.getSync();
             p1.getParallel();

         }*/
        static async Task Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            const int numParts = 5;
            Task<List<int>>[] primes = new Task<List<int>>[numParts];
            for (int i = 0; i < numParts; i++)
            {
                primes[i] = Asynchoronus.GetPrimeNumbersAsync(i == 0 ? 2 : i * 1000000 + 1, (i + 1) * 1000000);
            }
            var results = await Task.WhenAll(primes);
            Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", results.Sum(p => p.Count), sw.ElapsedMilliseconds);
        }
    }
}
