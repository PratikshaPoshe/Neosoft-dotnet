namespace LearnAbstraction
{
    public interface ICalculatorA //propertie, indexers, methods and events
    {
        double Add(double a, double b);
        double Substract(double a, double b);
    }
    public abstract class CalculatorB{
        public abstract double Add(params int[] numbers);
    }
}