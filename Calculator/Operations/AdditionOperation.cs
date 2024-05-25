using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.Operations
{
    public class AdditionOperation : MathOperation
    {
    AdditionOperation(
        IAdditionOperation additionOperation,
        ) : base("Сложение"){
        
        }
        
        public override double Calculate(double[] args)
        {
           
            return args.Sum();
        }
    }
}
