using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class NToNOperation : Operation<double>
    {
        public override string Name => "f в n степени (f^n)";
        public override double Calculate(double[] args)
        {
            return Math.Pow(args[0], args[1]);
        }
    }
}
