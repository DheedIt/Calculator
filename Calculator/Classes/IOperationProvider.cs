﻿using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public interface IOperationProvider
    {
        public IEnumerable<IOperation<double>> Get();
    }
}
