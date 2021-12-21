using System.Collections.Generic;
using BetterChainOfResponsibilityImplementation.Abstractions;

namespace BetterChainOfResponsibilityImplementation.Implementations
{
    public class Response : IResponse
    {
        public IReadOnlyCollection<string> Messages { get; }

        public Response(IReadOnlyCollection<string> messages)
        {
            Messages = messages;
        }
    }
}