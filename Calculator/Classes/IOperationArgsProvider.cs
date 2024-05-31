using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public interface IOperationArgsProvider<TArgs> where TArgs : struct
    {
        TArgs Get();
    }
}
