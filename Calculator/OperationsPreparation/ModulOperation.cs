using Calculator.Classes;
using Calculator.IOperations;
namespace Calculator.OperationsPreparation
{
    public class ModulOperation : MathOperation
    {
        ModulOperation(
            IModulOperation modulOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.modulOperation = modulOperation;
            this.args = args;
        }
        IModulOperation modulOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {
            OneStandartArgs args = this.args.Get();
            return modulOperation.Calculate(args.Number);
        }
    }
}
