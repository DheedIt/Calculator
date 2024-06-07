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
            IDivisionOperation divisionOperation,
            IOperationArgsProvider<NStandartArgs> args
            ) : base("Сложение")
        {
            this.divisionOperation = divisionOperation;
            this.args = args;
        }
        IDivisionOperation divisionOperation;
        IOperationArgsProvider<NStandartArgs> args;
        public override double Calculate()
        {

            NStandartArgs args = this.args.Get();
            return divisionOperation.Calculate(args.NumberArr);
        }
    }
}
