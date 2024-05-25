using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class OneDivsionOperation : Operation<double>
    {
        public override string Name => "n в -1 степени (1/n)";
        public override double Calculate(double[] args)
        {
            return 1 / args[0];
        }
    }
}
