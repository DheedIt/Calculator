using System;
using Calculator.Operations;
namespace Calculator.Classes
{
    
    public class ChooseOperation : IChooseOperation
    {
        ChooseOperation(IEnterOperationsNumber operationsNumber)
        {
            this.operationsNumber = operationsNumber;
        }
        IEnterOperationsNumber operationsNumber;
        public IOperation<double> returnOperation(IOperationProvider operation)
        {
            Console.WriteLine("Выберите действие");
            return operation.Get().ToArray()[operationsNumber.Get() - 1];
        }
    }
}
