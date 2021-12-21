using System;
using System.Collections.Generic;
using System.Linq;
using BetterChainOfResponsibilityImplementation.Abstractions;

namespace BetterChainOfResponsibilityImplementation.Implementations.Handlers
{
    public class AggregateHandler : HandlerBase
    {
        private readonly List<IHandler> m_Handlers;

        public AggregateHandler(params IHandler[] handlers)
        {
            if (handlers == null || !handlers.Any())
            {
                throw new ArgumentNullException(nameof(handlers), "No handlers are set.");
            }

            m_Handlers = new List<IHandler>();
            m_Handlers.AddRange(handlers);
        }

        public override IResponse Handle(IRequest originalRequest, IResponse accumulatedResponse = null)
        {
            var previousResponse = m_Handlers[0].Handle(originalRequest, accumulatedResponse);

            if (m_Handlers.Count > 1)
            {
                for (var handlerIndex = 1; handlerIndex < m_Handlers.Count; handlerIndex++)
                {
                    previousResponse = m_Handlers[handlerIndex].Handle(originalRequest, previousResponse);
                }
            }

            return previousResponse;
        }
    }
}