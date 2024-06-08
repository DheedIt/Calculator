using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class NToNOperation : MathOperation
    {
        NToNOperation(
            IPowNByNOperation powNByNOperation,
            IOperationArgsProvider<TwoStandartArgs> args
            ) : base("Сложение")
        {
            this.powNByNOperation = powNByNOperation;
            this.args = args;
        }
        IPowNByNOperation powNByNOperation;
        IOperationArgsProvider<TwoStandartArgs> args;
        public override double Calculate()
        {

            TwoStandartArgs args = this.args.Get();
            return powNByNOperation.Calculate(args.Number1, args.Number2);
        }
    }
}
