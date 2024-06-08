using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class OneDividedByNOperation : MathOperation
    {
        OneDividedByNOperation(
            IOneDividedByNOperation oneDividedByNOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.oneDividedByNOperation = oneDividedByNOperation;
            this.args = args;
        }
        IOneDividedByNOperation oneDividedByNOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {
            OneStandartArgs args = this.args.Get();
            return oneDividedByNOperation.Calculate(args.Number);
        }
    }
}
