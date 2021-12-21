using BetterChainOfResponsibilityImplementation.Abstractions;

namespace BetterChainOfResponsibilityImplementation.Implementations.Handlers
{
    public abstract class HandlerBase : IHandler
    {
        public abstract IResponse Handle(IRequest originalRequest, IResponse accumulatedResponse = null);
    }
}