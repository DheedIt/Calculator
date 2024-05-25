using Calculator.Menues;
using Castle.Windsor;
using Calculator.Operations;
namespace Calculator.Classes
{
    
    public class OperationProvider : IOperationProvider
    {
        private IEnumerable<Operation<double>> operations;
        public OperationProvider(IEnumerable<Operation<double>> operations)
        {
            this.operations = operations;
        }
        public IEnumerable<Operation<double>> Get()
        {
            return operations;
        }
    }
   
}
