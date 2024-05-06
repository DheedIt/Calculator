using System;
namespace Calculator.Classes
{
    class ShowOperations
    {
        public Operation<double>[] Show()
        {
            Operation<double>[] args = {new AdditionOperation(),
                                        new  SubstractionOperation(),
            new MultiplicationOperation(),
            new DivisionOperation(),
            new FactorialOperation(),
            new ModulOperation(),
            new LogarithmOperation(),
            new TenToNOperation(),
            new NToNOperation(),
            new SqrtOperation(),
            new TwoToNOperation(),
            new OneDivsionOperation(),
            new DivisionWithRemainderOperation(),
            new ExpoOperation(),
            new NToTwoOperation(),
            new ThirdSqrtOperation(),
            new NToThreeOperation()};
            return args;
        }
    }
}
