using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class MultiplicationOperation : Operation<double>
    {
        public override string Name => "Умножение (*)";
        public override double Calculate(double[] args)
        {
            for (int i = 1; i < args.Length; ++i)
                args[0] *= args[i];
            return args[0];
        }
    }
}
