using Calculator.Menues;
using Castle.Windsor;
namespace Calculator.Classes
{
    public interface IOperationProvider
    {
        public IEnumerable<Operation<double>> Get();
    }
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
    public class App
    {
        public App(
         IWindsorContainer container,
         IOperationProvider operationProvider,
         IMenu menu)
        {
            this.container = container;
            this.operationProvider = operationProvider;
            this.menu = menu;
        }
        private IWindsorContainer container;
        private IOperationProvider operationProvider;
        private IMenu menu;
        private IEnumerable<Operation<double>> operations;
        public static App staticStart;
        public void Run()
        {
            Output output = new Output();
            URequest rq = new URequest();
            ShowOperations showOperations = new ShowOperations();
            operations = operationProvider.Get();
            output.ResultOutput(menu.Show(operations.ToArray()).Calculate(rq.EnterN()));
        }

    }
}
