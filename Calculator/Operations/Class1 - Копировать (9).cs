using Calculator.IOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class PowNByExpo : IPowNByExpoOperation
    {
        public double Calculate(double arg)
        {
            return Math.Exp(arg);
        }
    }
}
