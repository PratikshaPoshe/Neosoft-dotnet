using System;

namespace LearnAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatorA calculator = new Calculator();
            Console.Write(calculator.Add(1,2));
        }
    }
}
