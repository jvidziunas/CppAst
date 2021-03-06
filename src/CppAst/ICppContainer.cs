﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections.Generic;

namespace CppAst
{
    /// <summary>
    /// Base tag interface used to describe a container of <see cref="CppElement"/>
    /// </summary>
    public interface ICppContainer
    {
        IEnumerable<CppElement> Children();
    }
}