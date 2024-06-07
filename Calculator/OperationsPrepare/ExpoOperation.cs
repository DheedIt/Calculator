using Calculator.Classes;
using Calculator.IOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    public class ExpoOperation : MathOperation
    {
        ExpoOperation(
            IExpoOperation expoOperation,
            IOperationArgsProvider<OneStandartArgs> args
            ) : base("Сложение")
        {
            this.expoOperation = expoOperation;
            this.args = args;
        }
        IExpoOperation expoOperation;
        IOperationArgsProvider<OneStandartArgs> args;
        public override double Calculate()
        {

            OneStandartArgs args = this.args.Get();
            return expoOperation.Calculate(args.Number);
        }
    }
}
