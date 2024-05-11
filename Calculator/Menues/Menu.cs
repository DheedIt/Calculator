using Calculator.Classes;
using System;

namespace Calculator.Menues
{
    public sealed class Menu : IMenu
    {

        public  Operation<double> Show(Operation<double>[] operations)
        {
                ChooseOperation choose = new ChooseOperation();
                Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
                for (int i = 0; i < operations.Length; i++)
                {
                    Operation<double> operation = operations[i];
                    Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operation.Name};");
                }
                return choose.returnOperation(operations);
        }
    }
}
