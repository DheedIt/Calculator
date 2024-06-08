using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class SubstractionOperation : MathOperation
    {
        SubstractionOperation(
            ISubstractionOperation substractionOperation,
            IOperationArgsProvider<NStandartArgs> args
            ) : base("Сложение")
        {
            this.substractionOperation = substractionOperation;
            this.args = args;
        }
        ISubstractionOperation substractionOperation;
        IOperationArgsProvider<NStandartArgs> args;
        public override double Calculate()
        {

            NStandartArgs args = this.args.Get();
            return substractionOperation.Calculate(args.NumberArr);
        }
    }
}
