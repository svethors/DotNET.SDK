﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Web;
using doLittle.Execution;

namespace doLittle.Web
{
    [Singleton]
    public class WebCallContext : ICallContext
    {
        public bool HasData(string key)
        {
            return HttpContext.Current.Items.Contains(key);
        }

        public T GetData<T>(string key)
        {
            return (T)HttpContext.Current.Items[key];
        }

        public void SetData(string key, object data)
        {
            HttpContext.Current.Items[key] = data;
        }
    }
}