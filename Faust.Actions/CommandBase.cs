using Autofac;
using Faust.DependencyInjection;

namespace Faust.Actions
{
    public abstract class CommandBase : ActionBase
    {
        public void Execute()
        {
            Run();
        }
        protected abstract void OnExecuting(ILifetimeScope scope);
        protected override void PerformAction()
        {
            OnExecuting(DependencyBootstrapper.BeginLifetimeScope());
        }
    }

    public abstract class CommandBase<TOut> : ActionBase
    {
        private TOut _result;
        protected abstract TOut OnExecuting(ILifetimeScope scope);
        protected override void PerformAction()
        {
            _result = OnExecuting(DependencyBootstrapper.BeginLifetimeScope());
        }

        public TOut Execute()
        {
            Run();
            return _result;
        }
    }
}
