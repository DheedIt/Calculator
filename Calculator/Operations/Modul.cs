using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Modul : IModulOperation
    {
        public double Calculate(double num)
        {
            if(num < 0) return num*-1;
            return num;
        }
    }
}
