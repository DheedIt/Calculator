using Calculator.Menues;
using Calculator.Operations;
using Castle.Windsor;

namespace Calculator.Classes
{
    public class App
    {
        public App(
         IOperationProvider operationProvider,
         IMenu menu,
         IOutput output
         )
        {
            this.operationProvider = operationProvider;
            this.menu = menu;
            this.output = output;
        }
        private IOperationProvider operationProvider;
        private IMenu menu;
        private IEnumerable<Operation<double>> operations;
        private IOutput output;
        public void Run()
        {
            operations = operationProvider.Get();
            output.ResultOutput(menu.Show().Calculate(rq.EnterNumbers()));
        }

    }
}
