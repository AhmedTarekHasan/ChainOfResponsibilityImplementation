using System.Collections.Generic;
using ChainOfResponsibilityImplementation.Abstractions;

namespace ChainOfResponsibilityImplementation.Implementations
{
    public class Request : IRequest
    {
        public int Id { get; }
        public IReadOnlyCollection<string> Messages { get; }

        public Request(int id, IReadOnlyCollection<string> messages)
        {
            Id = id;
            Messages = messages;
        }
    }
}