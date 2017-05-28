﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace doLittle.Collections
{
    /// <summary>
    /// Represents the delegate that gets called when items are removed from a collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <param name="items"></param>
    public delegate void ItemsRemovedFromCollection<T>(IObservableCollection<T> collection, IEnumerable<T> items);
}