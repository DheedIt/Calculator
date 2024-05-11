using Calculator.Classes;

namespace Calculator.Menues
{
    public interface IMenu
    {
        public Operation<double> Show(Operation<double>[] operations);
    }
}
