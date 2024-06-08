using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class AdditionOperation : MathOperation
    {
    AdditionOperation(
        IAdditionOperation additionOperation,
        IOperationArgsProvider<NStandartArgs> args
        ) : base("Сложение"){
        this.additionOperation = additionOperation;
            this.args = args;
        }
        IAdditionOperation additionOperation;
        IOperationArgsProvider<NStandartArgs> args;
        public override double Calculate()
        {

            NStandartArgs args = this.args.Get();
            return additionOperation.Calculate(args.NumberArr);
        }
    }
}
