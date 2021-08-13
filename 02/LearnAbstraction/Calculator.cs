namespace LearnAbstraction
{
    public class Calculator:CalculatorB, ICalculatorA
    {
        double ICalculatorA.Add(double a, double b){ //explicit implementation of interface
            return a+b;
        }
        double ICalculatorA.Substract(double a, double b){
            return a-b;
        }
        /// <summary>
        /// This method can take the variable number of arguments.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>double sum</returns>
        public override double Add(params int[] numbers){ 
            double sum=0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}