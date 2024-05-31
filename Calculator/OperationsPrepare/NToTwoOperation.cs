using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class NToTwoOperation : Operation<double>
    {
        public override string Name => "2 в n степени (2 ^ n)";
        public override double Calculate(double[] args)
        {

            return Math.Pow(2, args[0]);
        }
    }
}
