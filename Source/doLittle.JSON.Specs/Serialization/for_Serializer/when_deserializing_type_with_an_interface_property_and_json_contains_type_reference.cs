﻿using System;
using doLittle.Serialization;
using Machine.Specifications;

namespace doLittle.JSON.Specs.Serialization.for_Serializer
{
    public class when_deserializing_type_with_an_interface_property_and_json_contains_type_reference : given.a_serializer
    {
        const string json = "{\"Something\":{\"$type\":\"doLittle.JSON.Specs.Serialization.for_Serializer.SomethingImplementation, doLittle.JSON.Specs\",\"SomeValue\":\"Something\"}}";

        static ClassToSerialize instance;

        Establish context = () =>
                                {
                                    container_mock.Setup(c => c.Get<ClassToSerialize>()).Returns(new ClassToSerialize());
                                    container_mock.Setup(c => c.Get(Moq.It.IsAny<Type>())).Returns((Type t) => Activator.CreateInstance(t));
                                };

        Because of = () => instance = serializer.FromJson<ClassToSerialize>(json, SerializationOptions.IncludeTypeNamesOptions);

        It should_have_the_property_instance_set_to_instance_of_SomethingImplementation = () => instance.Something.ShouldBeOfExactType<SomethingImplementation>();
    }
}