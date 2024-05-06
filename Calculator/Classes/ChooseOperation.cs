using System;

namespace Calculator.Classes
{
    public class ChooseOperation
    {
        public Operation<double> returnOperation(Operation<double>[] operations)
        {
            Console.WriteLine("Выберите действие");
            return operations[Convert.ToInt32(Console.ReadLine()) - 1]; ;
        }
    }
}
