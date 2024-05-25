using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class ModulOperation : Operation<double>
    {
        public override string Name => "Модуль (|x|)";
        public override double Calculate(double[] args)
        {
            if (args[0] < 0)
                return args[0] * -1;
            else return args[0];
        }
    }
}
