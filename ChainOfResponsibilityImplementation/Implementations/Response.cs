using System.Collections.Generic;
using ChainOfResponsibilityImplementation.Abstractions;

namespace ChainOfResponsibilityImplementation.Implementations
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