﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using doLittle.Configuration;
using doLittle.DependencyInversion;

namespace doLittle.Web.Configuration
{
    /// <summary>
    /// Represents the configuration for Assets
    /// </summary>
    public class AssetsConfiguration: IFrontendTargetConfiguration
    {
        /// <summary>
        /// List of paths to be excluded from assets evaluation
        /// </summary>
        public IList<string> PathsToExclude { get; set; }

        /// <summary>
        /// Holds configuration for assets
        /// </summary>
        public AssetsConfiguration()
        {
            PathsToExclude = new List<string>();
        }

        public void Initialize(IContainer container)
        {
            
        }
    }
}
