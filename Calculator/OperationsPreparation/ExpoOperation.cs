using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class ExpoOperation : MathOperation
    {
        ExpoOperation(
            IExpoOperation expoOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.expoOperation = expoOperation;
            this.args = args;
        }
        IExpoOperation expoOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return expoOperation.Calculate(args.Number);
        }
    }
}
