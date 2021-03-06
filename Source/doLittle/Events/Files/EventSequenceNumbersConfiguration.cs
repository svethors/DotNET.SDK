﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Events.Files
{
    /// <summary>
    /// Represents the configuration related to <see cref="EventSequenceNumber"/>
    /// </summary>
    public class EventSequenceNumbersConfiguration
    {
        /// <summary>
        /// Gets or sets the path to where information related to <see cref="EventSequenceNumbers"/>
        /// should be stored
        /// </summary>
        public string Path { get; set; }
    }
}
