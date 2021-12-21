using System;
using System.Collections.Generic;
using System.Linq;
using ChainOfResponsibilityImplementation.Abstractions;

namespace ChainOfResponsibilityImplementation.Implementations.Handlers
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

        public override IResponse Handle(IRequest request)
        {
            if (m_Handlers.Count > 1)
            {
                for (var handlerIndex = 0; handlerIndex < m_Handlers.Count - 1; handlerIndex++)
                {
                    m_Handlers[handlerIndex].SetNextHandler(m_Handlers[handlerIndex + 1]);
                }
            }

            return m_Handlers[0].Handle(request);
        }
    }
}