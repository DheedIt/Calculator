using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public interface IChooseOperation
    {
        public IOperation<double> returnOperation(IOperationProvider operation);
    }
}
