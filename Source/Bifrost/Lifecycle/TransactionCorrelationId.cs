﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Bifrost.Concepts;

namespace Bifrost.Lifecycle
{
    /// <summary>
    /// Represents a uniquely identifiable correlation id associated with typically <see cref="ITransaction"/>
    /// </summary>
    public class TransactionCorrelationId : ConceptAs<Guid>
    {
        /// <summary>
        /// Implicitly convert from a <see cref="Guid"/> to a <see cref="TransactionCorrelationId"/>
        /// </summary>
        /// <param name="value"><see cref="Guid"/> for the value</param>
        public static implicit operator TransactionCorrelationId(Guid value)
        {
            return new TransactionCorrelationId { Value = value };
        }
    }
}
