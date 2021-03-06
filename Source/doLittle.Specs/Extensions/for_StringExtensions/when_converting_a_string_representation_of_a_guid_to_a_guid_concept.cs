﻿using System;
using doLittle.Extensions;
using Machine.Specifications;

namespace doLittle.Specs.Extensions.for_StringExtensions
{
    [Subject(typeof(StringExtensions))]
    public class when_converting_a_string_representation_of_a_guid_to_a_guid_concept
    {
        static string guid_as_a_string;
        static ConceptAsGuid result;

        Establish context = () =>
            {
                guid_as_a_string = Guid.NewGuid().ToString();
            };

        Because of = () => result = (ConceptAsGuid)guid_as_a_string.ParseTo(typeof(ConceptAsGuid));

        It should_create_a_guid_concept = () => result.ShouldBeOfExactType<ConceptAsGuid>();
        It should_have_the_correct_value = () => result.ToString().ShouldEqual(guid_as_a_string);
    }
}