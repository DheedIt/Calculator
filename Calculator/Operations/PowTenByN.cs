using Calculator.IOperations;
namespace Calculator.Operations
{
    public class PowTenByN : IPowTenByNOperation
    {
        public double Calculate(double num)
        {
            return Math.Pow(10d, num);
        }
    }
}
