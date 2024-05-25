using Calculator.Menues;
using Calculator.Operations;
using Castle.Windsor;

namespace Calculator.Classes
{
    public interface IOperation<Operation>{
        Operation Calculate();
    }
}