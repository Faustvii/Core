using Autofac;

namespace Faust.DependencyInjection
{
    public class DependencyBootstrapper
    {
        public static IContainer Current { get; private set; }

        public ContainerBuilder Builder { get; }

        static DependencyBootstrapper()
        {
            Current = new ContainerBuilder().Build();
        }

        public DependencyBootstrapper()
        {
            Builder = new ContainerBuilder();
        }

        public static ILifetimeScope BeginLifetimeScope()
        {
            return Current.BeginLifetimeScope();
        }

        public IContainer Setup()
        {
            return Current = Builder.Build();
        }
    }
}
