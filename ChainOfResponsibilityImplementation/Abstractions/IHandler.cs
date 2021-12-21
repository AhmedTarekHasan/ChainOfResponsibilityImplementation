namespace ChainOfResponsibilityImplementation.Abstractions
{
    public interface IHandler
    {
        void SetNextHandler(IHandler next);
        IResponse Handle(IRequest request);
    }
}