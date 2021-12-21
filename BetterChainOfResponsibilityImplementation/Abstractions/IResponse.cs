using System.Collections.Generic;

namespace BetterChainOfResponsibilityImplementation.Abstractions
{
    public interface IResponse
    {
        IReadOnlyCollection<string> Messages { get; }
    }
}