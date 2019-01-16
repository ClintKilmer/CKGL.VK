// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.NVidia
{
    /// <summary>
    /// Structure specifying a viewport swizzle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ViewportSwizzle
    {
        /// <summary>
        /// 
        /// </summary>
        public ViewportSwizzle(SharpVk.NVidia.ViewportCoordinateSwizzle x, SharpVk.NVidia.ViewportCoordinateSwizzle y, SharpVk.NVidia.ViewportCoordinateSwizzle z, SharpVk.NVidia.ViewportCoordinateSwizzle w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }
        
        /// <summary>
        /// The swizzle operation to apply to the x component of the primitive
        /// </summary>
        public SharpVk.NVidia.ViewportCoordinateSwizzle X; 
        
        /// <summary>
        /// The swizzle operation to apply to the y component of the primitive
        /// </summary>
        public SharpVk.NVidia.ViewportCoordinateSwizzle Y; 
        
        /// <summary>
        /// The swizzle operation to apply to the z component of the primitive
        /// </summary>
        public SharpVk.NVidia.ViewportCoordinateSwizzle Z; 
        
        /// <summary>
        /// The swizzle operation to apply to the w component of the primitive
        /// </summary>
        public SharpVk.NVidia.ViewportCoordinateSwizzle W; 
    }
}
