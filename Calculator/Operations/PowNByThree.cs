using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowNByThree : IPowNByThreeOperation
    {
        public double Calculate(double num)
        {
            return Math.Pow(num, 3);
        }
    }
}
