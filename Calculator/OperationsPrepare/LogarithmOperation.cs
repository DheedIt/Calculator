using Calculator.Classes;
using Calculator.IOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    public class LogarithmOperation : MathOperation
    {
        LogarithmOperation(
            ILogarithmOperation logarithmOperation,
            IOperationArgsProvider<TwoStandartArgs> args
            ) : base("Сложение")
        {
            this.logarithmOperation = logarithmOperation;
            this.args = args;
        }
        ILogarithmOperation logarithmOperation;
        IOperationArgsProvider<TwoStandartArgs> args;
        public override double Calculate()
        {

            TwoStandartArgs args = this.args.Get();
            return logarithmOperation.Calculate(args.Number1, args.Number2);
        }
    }
}
