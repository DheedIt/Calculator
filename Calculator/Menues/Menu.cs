using Calculator.Classes;
using Calculator.Operations;
using System;

namespace Calculator.Menues
{
    public sealed class Menu : IMenu<IOperation<double>>
    {
        Menu(IOperationProvider operations,
            IChooseOperation choose,
            IOperation<double> _operation)
        {
            this.operations = operations;
            this.choose = choose;
            this._operation = _operation;
        }
IOperation<double> _operation;
        IChooseOperation choose;
        IOperationProvider operations;

        public IOperation<double> Show()
        {
                Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
                for (int i = 0; i < operations.Get().Count(); i++)
                {
                    IOperation<double> operation = operations.Get().ToArray()[i];
                    Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name};");
                }
                return choose.returnOperation(operations);
        }
    }
}
