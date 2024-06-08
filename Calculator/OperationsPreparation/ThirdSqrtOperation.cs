using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class ThirdSqrtOperation : MathOperation
    {
        ThirdSqrtOperation(
            IThirdSqrtOperation thirdSqrtOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.thirdSqrtOperation = thirdSqrtOperation;
            this.args = args;
        }
        IThirdSqrtOperation thirdSqrtOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return thirdSqrtOperation.Calculate(args.Number);
        }
    }
}
