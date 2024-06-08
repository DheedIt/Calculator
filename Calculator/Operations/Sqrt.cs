using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Sqrt : ISqrtOperation
    {
        public double Calculate(double num)
        {
            return Math.Sqrt(num);
        }
    }
}
