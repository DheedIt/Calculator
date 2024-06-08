using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowTwoByN : IPowTwoByNOperation
    {
        public double Calculate(double num)
        {
            return Math.Pow(2,num);
        }
    }
}
