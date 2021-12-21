using System.Collections.Generic;
using BetterChainOfResponsibilityImplementation.Abstractions;

namespace BetterChainOfResponsibilityImplementation.Implementations.Handlers
{
    public class Handler2 : HandlerBase
    {
        public override IResponse Handle(IRequest originalRequest, IResponse accumulatedResponse = null)
        {
            List<string> newMessages;

            if (accumulatedResponse != null)
            {
                newMessages = new List<string>(accumulatedResponse.Messages) { "Handled by Handler 2" };
            }
            else
            {
                newMessages = new List<string>(originalRequest.Messages) { "Handled by Handler 2" };
            }

            return new Response(newMessages);
        }
    }
}