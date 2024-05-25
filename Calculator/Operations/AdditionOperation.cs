using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class AdditionOperation : Operation<double>
    {
        public override string Name => "Сложение (/)";
        public override double Calculate(double[] args)
        {
           
            return args.Sum();
        }
    }
}
