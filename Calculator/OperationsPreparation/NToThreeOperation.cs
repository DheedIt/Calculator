using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowNByThreeOperation : MathOperation
    {
        PowNByThreeOperation(
            IPowNByThreeOperation powNByThreeOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powNByThreeOperation = powNByThreeOperation;
            this.args = args;
        }
        IPowNByThreeOperation powNByThreeOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {
            OneStandartArgs args = this.args.Get();
            return powNByThreeOperation.Calculate(args.Number);
        }
    }
}
