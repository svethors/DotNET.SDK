﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Execution
{
    /// <summary>
    /// Defines a factory for creating <see cref="IExecutionContext"/> instances
    /// </summary>
    public interface IExecutionContextFactory
    {
        /// <summary>
        /// Create a new <see cref="IExecutionContext"/>
        /// </summary>
        /// <returns>A <see cref="IExecutionContext"/></returns>
        IExecutionContext Create();
    }
}
