using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class NToThreeOperation : Operation<double>
    {
        public override string Name => "Куб числа (n ^ 3)";
        public override double Calculate(double[] args)
        {
            return Math.Pow(args[0], 3);
        }
    }
}
