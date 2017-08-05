using Autofac;
using Faust.DependencyInjection;
using System.Collections.Generic;

namespace Faust.Actions
{
    public abstract class QueryBaseSingle<TOut> : ActionBase
    {
        private TOut _result;

        public TOut Execute()
        {
            Run();
            return _result;
        }
        protected abstract TOut OnExecuting(ILifetimeScope scope);
        protected override void PerformAction()
        {
            _result = OnExecuting(DependencyBootstrapper.BeginLifetimeScope());
        }
    }

    public abstract class QueryBase<TOut> : ActionBase
    {
        private IEnumerable<TOut> _result;

        public IEnumerable<TOut> Execute()
        {
            Run();
            return _result;
        }
        protected abstract IEnumerable<TOut> OnExecuting(ILifetimeScope scope);
        protected override void PerformAction()
        {
            _result = OnExecuting(DependencyBootstrapper.BeginLifetimeScope());
        }
    }
}
