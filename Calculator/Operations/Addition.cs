using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Addition : IAdditionOperation
    {
        public double Calculate(double[] args)
        {
            return args.Sum();
        }
    }
}
