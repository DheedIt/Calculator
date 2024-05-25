using Calculator.Operations;
using Calculator.Classes;
namespace Calculator.Menues
{
    public interface IMenu<out T> where T : IOperation<double>
{
    public IMenu<T> Show();

}
}
