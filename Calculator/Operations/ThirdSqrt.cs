using Calculator.IOperations;
namespace Calculator.Operations
{
    public class ThirdSqrt : IThirdSqrtOperation
    {
        public double Calculate(double num)
        {
            return Math.Pow(num, 1d / 3d);
        }
    }
}
