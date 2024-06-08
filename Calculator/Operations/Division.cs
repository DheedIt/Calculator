﻿using Calculator.IOperations;
namespace Calculator.Operations
{
    public class Division : IDivisionOperation
    {
        public double Calculate(double[] args)
        {
           for(int i = 1; i < args.Length; i++)
            {
                args[0] /= args[i];
            }
            return args[0];
        }
    }
}
