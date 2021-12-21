using System.Collections.Generic;

namespace ChainOfResponsibilityImplementation.Abstractions
{
    public interface IResponse
    {
        IReadOnlyCollection<string> Messages { get; }
    }
}