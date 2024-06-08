using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Substraction : ISubstractionOperation
    {
        public double Calculate(double[] args)
        {
            return args[0] - (args.Sum() - args[0]);
        }
    }
}
