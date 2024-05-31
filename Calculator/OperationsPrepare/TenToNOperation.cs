using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class TenToNOperation : Operation<double>
    {
        public override string Name => "10 в n степени (10^n)";
        public override double Calculate(double[] args)
        {
            return Math.Pow(10, args[0]);
        }
    }
}
