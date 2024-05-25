using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class ThirdSqrtOperation : Operation<double>
    {
        public override string Name => "Квадратный корень из n (∛n)";
        public override double Calculate(double[] args)
        {
            return Math.Pow(args[0], (1d / 3d));
        }
    }
}
