using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationsPrepare
{
    class DivisionWithRemainderOperation : Operation<double>
    {
        public override string Name => "Деление с остатком (%)";
        public override double Calculate(double[] args)
        {
            for (int i = 1; i < args.Length; ++i)
                if (args[i] == 0)
                    throw new Exception("Division by zero\n");
                else
                    args[0] %= args[i];
            return args[0];
        }
    }
}
