using System;
namespace Calculator.Classes
{
    public class Output : IOutput
    {
        public void ResultOutput(double result)
        {
            Console.WriteLine("Result: {0}", result);
        }
    }
}
