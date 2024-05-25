using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public abstract class Operation<T>
    {
        public abstract string Name { get; }
        abstract public T Calculate(T[] args);
    }
}
