using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowTenToNOperation : MathOperation
    {
        PowTenToNOperation(
            IPowTenToNOperation powTenToNOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powTenToNOperation = powTenToNOperation;
            this.args = args;
        }
        IPowTenToNOperation powTenToNOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return powTenToNOperation.Calculate(args.Number);
        }
    }
}
