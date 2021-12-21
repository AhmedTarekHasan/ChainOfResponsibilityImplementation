namespace BetterChainOfResponsibilityImplementation.Abstractions
{
    public interface IHandler
    {
        IResponse Handle(IRequest originalRequest, IResponse accumulatedResponse = null);
    }
}