﻿// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace CppAst
{
    /// <summary>
    /// A C++ pointer type (e.g `int*`)
    /// </summary>
    public sealed class CppPointerType : CppType
    {
        /// <summary>
        /// Constructor of a pointer type.
        /// </summary>
        /// <param name="elementType">The element type pointed to.</param>
        public CppPointerType(CppType elementType) : base(CppTypeKind.Pointer)
        {
            ElementType = elementType ?? throw new ArgumentNullException(nameof(elementType));
        }

        /// <summary>
        /// Gets the element type pointed by this pointer type.
        /// </summary>
        public CppType ElementType { get; }

        private bool Equals(CppPointerType other)
        {
            return base.Equals(other) && ElementType.Equals(other.ElementType);
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is CppPointerType other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ ElementType.GetHashCode();
            }
        }

        public override string ToString()
        {
            return $"{ElementType.GetDisplayName()}*";
        }
    }
}