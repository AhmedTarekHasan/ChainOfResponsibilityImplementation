using System.Collections.Generic;
using BetterChainOfResponsibilityImplementation.Abstractions;

namespace BetterChainOfResponsibilityImplementation.Implementations.Handlers
{
    public class Handler1 : HandlerBase
    {
        public override IResponse Handle(IRequest originalRequest, IResponse accumulatedResponse = null)
        {
            List<string> newMessages;

            if (accumulatedResponse != null)
            {
                newMessages = new List<string>(accumulatedResponse.Messages) { "Handled by Handler 1" };
            }
            else
            {
                newMessages = new List<string>(originalRequest.Messages) { "Handled by Handler 1" };
            }

            return new Response(newMessages);
        }
    }
}