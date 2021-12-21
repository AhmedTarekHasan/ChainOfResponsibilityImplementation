using ChainOfResponsibilityImplementation.Abstractions;

namespace ChainOfResponsibilityImplementation.Implementations.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        protected IHandler NextHandler;

        public void SetNextHandler(IHandler next)
        {
            NextHandler = next;
        }

        public abstract IResponse Handle(IRequest request);
    }
}