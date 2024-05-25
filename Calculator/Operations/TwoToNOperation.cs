using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class TwoToNOperation : Operation<double>
    {
        public override string Name => "Квадрат числа (n ^ 2)";
        public override double Calculate(double[] args)
        {
            return Math.Pow(2, args[0]);
        }
    }
}
