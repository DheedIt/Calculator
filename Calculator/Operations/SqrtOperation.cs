using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class SqrtOperation : Operation<double>
    {
        public override string Name => "Корень числа (√n)";
        public override double Calculate(double[] args)
        {
            return Math.Sqrt(args[0]);
        }
    }
}
