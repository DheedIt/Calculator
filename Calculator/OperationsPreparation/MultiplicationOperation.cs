using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class MultiplicationOperation : MathOperation
    {
        MultiplicationOperation(
            IMultiplicationOperation multiplicationOperation,
            IOperationArgsProvider<NStandartArgs> args
            ) : base("Сложение")
        {
            this.multiplicationOperation = multiplicationOperation;
            this.args = args;
        }
        IMultiplicationOperation multiplicationOperation;
        IOperationArgsProvider<NStandartArgs> args;
        public override double Calculate()
        {

            NStandartArgs args = this.args.Get();
            return multiplicationOperation.Calculate(args.NumberArr);
        }
    }
}
