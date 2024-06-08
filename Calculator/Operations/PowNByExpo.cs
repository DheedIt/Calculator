using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowNByExpo : IPowNByExpoOperation
    {
        public double Calculate(double arg)
        {
            return Math.Exp(arg);
        }
    }
}
