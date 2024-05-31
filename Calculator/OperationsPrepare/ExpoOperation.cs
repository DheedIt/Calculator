using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class ExpoOperation : Operation<double>
    {
        public override string Name => "e в n степени (e^n)";
        public override double Calculate(double[] args)
        {
            
            return Math.Exp(args[0]);
        }
    }
}
