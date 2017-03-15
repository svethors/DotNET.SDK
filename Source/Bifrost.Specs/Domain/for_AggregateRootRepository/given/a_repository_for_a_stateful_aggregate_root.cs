﻿using Bifrost.Commands;
using Bifrost.Domain;
using Machine.Specifications;
using Moq;

namespace Bifrost.Specs.Domain.for_AggregateRootRepository.given
{
    public class a_repository_for_a_stateful_aggregate_root : all_dependencies
	{
		protected static AggregateRootRepository<SimpleStatefulAggregateRoot> repository;
	    protected static Mock<ICommandContext> command_context_mock;

		Establish context = () =>
		                    {
                                command_context_mock = new Mock<ICommandContext>();
								
								repository = new AggregateRootRepository<SimpleStatefulAggregateRoot>(command_context_manager.Object);
		                        command_context_manager.Setup(ccm => ccm.GetCurrent()).Returns(command_context_mock.Object);
		                    };
	}
}
