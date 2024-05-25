using Calculator.Classes;
using Calculator.Operations;
using System;

namespace Calculator.Menues
{
    public sealed class Menu : IMenu
    {
        Menu(IOperationProvider operations,
            IChooseOperation choose)
        {
            this.operations = operations;
            this.choose = choose;
        }

        IChooseOperation choose;
        IOperationProvider operations;

        public Operation<double> Show()
        {
                Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
                for (int i = 0; i < operations.Get().Count(); i++)
                {
                    Operation<double> operation = operations.Get().ToArray()[i];
                    Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name};");
                }
                return choose.returnOperation(operations);
        }
    }
}
