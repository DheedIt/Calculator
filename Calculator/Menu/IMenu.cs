using Calculator.Classes;

namespace Calculator.Menu
{
    public interface IMenu
    {
        public Operation<double> Show(Operation<double>[] operations);
    }
}
