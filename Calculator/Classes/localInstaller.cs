using Calculator.Menues;
using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;


namespace Calculator.Classes
{
    public class LocalInstaller : IWindsorInstaller
    {
       
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<App>()
                         .StartUsingMethod("Run"),

                Component.For<IMenu>()
                         .ImplementedBy<Menu>()
                         .LifestyleTransient(),
                
                Component.For<IOperationProvider>()
                         .ImplementedBy<OperationProvider>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<AdditionOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<SubstractionOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<MultiplicationOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<DivisionOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<FactorialOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<ModulOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<LogarithmOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<TenToNOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<NToNOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<SqrtOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<TwoToNOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<OneDivsionOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<DivisionWithRemainderOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<ExpoOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<NToTwoOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<ThirdSqrtOperation>(),
                Component.For<Operation<double>>()
                         .ImplementedBy<NToThreeOperation>()
            );
            
        }
    }
}
