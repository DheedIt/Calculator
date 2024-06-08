using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class FactorialOperation : MathOperation
    {
        FactorialOperation(
            IFactorialOperation factorialOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.factorialOperation = factorialOperation;
            this.args = args;
        }
        IFactorialOperation factorialOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return factorialOperation.Calculate(args.Number);
        }
    }
}
