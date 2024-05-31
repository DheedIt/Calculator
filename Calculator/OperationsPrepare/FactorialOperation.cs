using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class FactorialOperation : Operation<double>
    {
        public override string Name => "Факториал (!)";
        public override double Calculate(double[] args)
        {
            int k = 1;
            for (int i = 1; i <= args[0]; ++i)
                k *= i;
            return k;
        }
    }
}
