
namespace Calculator.Classes
{
    public abstract class MathOperation : IOperation<double>
    {
        protected MathOperation(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract double Calculate();
    }
}