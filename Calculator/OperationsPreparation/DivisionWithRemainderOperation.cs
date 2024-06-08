using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class DivisionWithRemainderOperation : MathOperation
    {
        DivisionWithRemainderOperation(
            IDivisionWithRemainderOperation divisionOperation,
            IOperationArgsProvider<NStandartArgs> args
            ) : base("Сложение")
        {
            this.divisionOperation = divisionOperation;
            this.args = args;
        }
        IDivisionWithRemainderOperation divisionOperation;
        IOperationArgsProvider<NStandartArgs> args;
        public override double Calculate()
        {

            NStandartArgs args = this.args.Get();
            return divisionOperation.Calculate(args.NumberArr);
        }
    }
}
