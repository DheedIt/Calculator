using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class SqrtOperation : MathOperation
    {
        SqrtOperation(
            ISqrtOperation sqrtOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.sqrtOperation = sqrtOperation;
            this.args = args;
        }
        ISqrtOperation sqrtOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {
            OneStandartArgs args = this.args.Get();
            return sqrtOperation.Calculate(args.Number);
        }
    }
}
