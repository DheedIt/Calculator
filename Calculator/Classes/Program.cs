using Calculator.Classes;
using Castle.Facilities.Startable;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
internal class Program
{
    private static IWindsorContainer _container = new WindsorContainer();
    static void Main(string[] args)
    {
        try
        {
            Start();
        }
        catch (Exception exep)
        {
            Console.Clear();
            Console.WriteLine(exep.Message);
        }
    }
    public static void Start()
    {
        {
            _container.AddFacility<StartableFacility>(f => f.DeferredStart());
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
            _container.Install(new LocalInstaller());
        }

    }
}