﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Linq;
using System.Reflection;
using doLittle.Types;
using doLittle.DependencyInversion;

namespace doLittle.Tenancy
{
    /// <summary>
    /// Represents an implementation of <see cref="ITenancyConfiguration"/>
    /// </summary>
    public class TenancyConfiguration : ITenancyConfiguration
    {
        /// <inheritdoc/>
        public void Initialize(IContainer container)
        {
            var tyepFinder = container.Get<ITypeFinder>();

            var resolverType = typeof(DefaultTenantIdResolver);
            var resolverTypes = tyepFinder.FindMultiple<ICanResolveTenantId>().Where(t => t.GetTypeInfo().Assembly != typeof(TenancyConfiguration).GetTypeInfo().Assembly);
            if (resolverTypes.Count() > 1) throw new MultipleTenantIdResolversFound();
            if (resolverTypes.Count() == 1) resolverType = resolverTypes.First();

            container.Bind<ICanResolveTenantId>(resolverType);

            container.Bind(() => container.Get<ITenantManager>().Current);
        }
    }
}
