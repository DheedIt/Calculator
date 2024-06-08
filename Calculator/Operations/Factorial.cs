using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Factorial : IFactorialOperation
    {
        public double Calculate(double num)
        {
            for(int i = (int)num-1; i!=1; --i)
            {
                num *= i;
            }
            return num;
        }
    }
}
