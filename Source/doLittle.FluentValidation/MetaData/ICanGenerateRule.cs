﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using doLittle.Conventions;
using doLittle.Validation.MetaData;
using FluentValidation.Validators;

namespace doLittle.FluentValidation.MetaData
{
    /// <summary>
    /// Defines a system that can generate rule from a Fluent Validation property validator.
    /// </summary>
    public interface ICanGenerateRule : IConvention
    {
        /// <summary>
        /// Types that are supported by the generator
        /// </summary>
        Type[] From { get; }

        /// <summary>
        /// Generate from a specific <see cref="IPropertyValidator"/>
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        /// <param name="propertyValidator"><see cref="IPropertyValidator"/></param>
        /// <returns></returns>
        Rule GeneratorFrom(string propertyName, IPropertyValidator propertyValidator);
    }
}
