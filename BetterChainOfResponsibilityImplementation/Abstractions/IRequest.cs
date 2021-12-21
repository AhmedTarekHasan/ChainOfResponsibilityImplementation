using System.Collections.Generic;

namespace BetterChainOfResponsibilityImplementation.Abstractions
{
    public interface IRequest
    {
        int Id { get; }
        IReadOnlyCollection<string> Messages { get; }
    }
}