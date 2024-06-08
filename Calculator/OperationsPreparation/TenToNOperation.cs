using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowTenToNOperation : MathOperation
    {
        PowTenToNOperation(
            IPowTenByNOperation powTenToNOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powTenToNOperation = powTenToNOperation;
            this.args = args;
        }
        IPowTenByNOperation powTenToNOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return powTenToNOperation.Calculate(args.Number);
        }
    }
}
