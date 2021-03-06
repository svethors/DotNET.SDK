﻿using System;
using doLittle.Domain;

namespace doLittle.Specs.Events.Fakes
{
    public class StatelessAggregatedRootWithOneMethod : AggregateRoot
    {
        public StatelessAggregatedRootWithOneMethod(Guid id) : base(id)
        {
        }

        public static void ResetState()
        {
            DoSomethingCalled = false;
        }

        public static bool DoSomethingCalled { get; set; }

        static StatelessAggregatedRootWithOneMethod()
        {
            DoSomethingCalled = false;
        }

        public void DoSomething(string input)
        {
            DoSomethingCalled = true;
        }
    }
}