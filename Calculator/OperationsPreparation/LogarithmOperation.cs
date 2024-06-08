using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class LogarithmOperation : MathOperation
    {
        LogarithmOperation(
            ILogarithmOperation logarithmOperation,
            IOperationArgsProvider<TwoStandartArgs> args
            ) : base("Сложение")
        {
            this.logarithmOperation = logarithmOperation;
            this.args = args;
        }
        ILogarithmOperation logarithmOperation;
        IOperationArgsProvider<TwoStandartArgs> args;
        public override double Calculate()
        {

            TwoStandartArgs args = this.args.Get();
            return logarithmOperation.Calculate(args.Number1, args.Number2);
        }
    }
}
