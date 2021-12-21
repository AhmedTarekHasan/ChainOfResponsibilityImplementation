using System.Collections.Generic;
using ChainOfResponsibilityImplementation.Abstractions;

namespace ChainOfResponsibilityImplementation.Implementations.Handlers
{
    public class Handler2 : HandlerBase
    {
        public override IResponse Handle(IRequest request)
        {
            var newMessages = new List<string>(request.Messages) { "Handled by Handler 2" };

            if (NextHandler != null)
            {
                var newRequest = new Request(request.Id, newMessages);
                return NextHandler.Handle(newRequest);
            }

            return new Response(newMessages);
        }
    }
}