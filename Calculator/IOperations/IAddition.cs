using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace Calculator.IOperations
{
    public interface IAdditionOperation
    {
        public string Name { get; }
        public double Calculate(double[] args);
    }
}

