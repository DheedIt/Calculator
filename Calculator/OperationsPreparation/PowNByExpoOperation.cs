using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowNByExpoOperation : MathOperation
    {
        PowNByExpoOperation(
            IPowNByExpoOperation powNByExpoOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powNByExpoOperation = powNByExpoOperation;
            this.args = args;
        }
        IPowNByExpoOperation powNByExpoOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return powNByExpoOperation.Calculate(args.Number);
        }
    }
}
