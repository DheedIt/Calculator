using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class LogarithmOperation : Operation<double>
    {
        public override string Name => "Логарифм с основанием a (loga x)";
        public override double Calculate(double[] args)
        {
            return Math.Log(args[0], args[1]);
        }
    }
}
