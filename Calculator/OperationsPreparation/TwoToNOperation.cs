using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class PowTwoToNOperation : MathOperation
    {
        PowTwoToNOperation(
            IPowTwoToNOperation powTwoToNOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.powTwoToNOperation = powTwoToNOperation;
            this.args = args;
        }
        IPowTwoToNOperation powTwoToNOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return powTwoToNOperation.Calculate(args.Number);
        }
    }
}
