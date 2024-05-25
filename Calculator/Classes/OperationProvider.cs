using Calculator.Menues;
using Castle.Windsor;
using Calculator.Operations;
namespace Calculator.Classes
{
    
    public class OperationProvider : IOperationProvider
    {
        private IEnumerable operations;
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
