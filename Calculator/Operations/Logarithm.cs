using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Logarithm : ILogarithmOperation
    {
        public double Calculate(double num1, double num2)
        {
            return Math.Log(num1, num2);
        }
    }
}
