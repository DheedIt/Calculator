using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowNByTwoOperation : MathOperation
    {
        PowNByTwoOperation(
            IPowNByTwoOperation powNByTwoOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powNByTwoOperation = powNByTwoOperation;
            this.args = args;
        }
        IPowNByTwoOperation powNByTwoOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {
            OneStandartArgs args = this.args.Get();
            return powNByTwoOperation.Calculate(args.Number);
        }
    }
}
