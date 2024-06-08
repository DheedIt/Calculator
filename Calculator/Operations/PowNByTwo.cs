using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowNByTwo : IPowNByTwoOperation
    {
        public double Calculate(double num)
        {
            return Math.Pow(num, 2);
        }
    }
}
