using System.Collections.Generic;

namespace ChainOfResponsibilityImplementation.Abstractions
{
    public interface IRequest
    {
        int Id { get; }
        IReadOnlyCollection<string> Messages { get; }
    }
}