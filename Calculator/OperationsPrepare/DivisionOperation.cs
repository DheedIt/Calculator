using Calculator.Classes;
using Calculator.IOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    public class DivisionOperation : MathOperation
    {
        DivisionOperation(
            IAdditionOperation additionOperation,
            IOperationArgsProvider<NStandartArgs> args
            ) : base("Сложение")
        {
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
