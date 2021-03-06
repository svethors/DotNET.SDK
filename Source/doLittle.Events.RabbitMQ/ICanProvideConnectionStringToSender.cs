/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Events.RabbitMQ
{
    /// <summary>
    /// Defines something that can provide a connection string for Redis
    /// </summary>
    public delegate string ICanProvideConnectionStringToSender();
}