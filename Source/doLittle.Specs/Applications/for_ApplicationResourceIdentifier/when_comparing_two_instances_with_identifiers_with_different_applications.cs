﻿using Machine.Specifications;
using It = Machine.Specifications.It;

namespace doLittle.Specs.Applications.for_ApplicationResourceIdentifier
{
    public class when_comparing_two_instances_with_identifiers_with_different_applications : given.identifiers_with_different_applications
    {
        static bool result;

        Because of = () => result = identifier_a == identifier_b;

        It should_not_be_considered_the_same = () => result.ShouldBeFalse();
    }
}
