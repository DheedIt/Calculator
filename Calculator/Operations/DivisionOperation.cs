﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class DivisionOperation : Operation<double>
    {
        public override string Name => "Деление (/)";
        public override double Calculate(double[] args)
        {
            for (int i = 1; i < args.Length; ++i)
                if (args[i] == 0)
                {
                    Console.WriteLine("Division by zero\n");
                    break;
                }
                else
                    args[0] /= args[i];
            return args[0];
        }
    }
}
