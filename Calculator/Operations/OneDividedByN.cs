using Calculator.IOperations;
namespace Calculator.Operations
{
    public class OneDividedByN : IOneDividedByNOperation
    {
        public double Calculate(double num)
        {
            return (1 / num);
        }
    }
}
