using System;
using System.Collections.Generic;
using BetterChainOfResponsibilityImplementation.Implementations;
using BetterChainOfResponsibilityImplementation.Implementations.Handlers;

namespace BetterChainOfResponsibilityImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialRequest = new Request(1, new List<string> { "This is the initial request" });

            var aggregateHandler1 = new AggregateHandler(
                new Handler1(),
                new Handler2());

            Console.WriteLine(string.Join("\n\r", aggregateHandler1.Handle(initialRequest).Messages));

            var aggregateHandler2 = new AggregateHandler(
                new Handler2(),
                new Handler1());

            Console.WriteLine();

            Console.WriteLine(string.Join("\n\r", aggregateHandler2.Handle(initialRequest).Messages));

            Console.ReadLine();
        }
    }
}