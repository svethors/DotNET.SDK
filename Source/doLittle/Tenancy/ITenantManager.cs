﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Tenancy
{
    /// <summary>
    /// Defines a system that manages <see cref="ITenant"/>
    /// </summary>
    public interface ITenantManager
    {
        /// <summary>
        /// Gets the current <see cref="ITenant"/>
        /// </summary>
        ITenant Current { get; }
    }
}
