using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowNByN :IPowNByNOperation
    {
        public double Calculate(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
