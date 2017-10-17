using Serilog;
using System;

namespace Faust.Actions
{
    public abstract class ActionBase
    {
        protected ILogger Logger;
        public virtual TimeSpan? WarnIfExecutionExceeds => null;

        public ActionBase()
        {
            Logger = Log.Logger;
        }

        internal void Run()
        {
            using (Logger?.BeginTimedOperation($"Executing {GetType().Name}", warnIfExceeds:WarnIfExecutionExceeds))
            {
                PerformAction();
            }
        }

        protected abstract void PerformAction();
    }
}
