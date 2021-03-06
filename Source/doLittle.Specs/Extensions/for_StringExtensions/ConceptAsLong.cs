﻿using doLittle.Concepts;

namespace doLittle.Specs.Extensions.for_StringExtensions
{
    public class ConceptAsLong : ConceptAs<long>
    {
        public static implicit operator ConceptAsLong(long value)
        {
            return new ConceptAsLong { Value = value };
        }
    }
}