﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;

namespace doLittle.Web.Assets
{
    public interface IAssetsManager
    {
        IEnumerable<string> GetFilesForExtension(string extension);
        IEnumerable<string> GetStructureForExtension(string extension);
        void AddAsset(string relativePath);

        void Initialize();
    }
}
