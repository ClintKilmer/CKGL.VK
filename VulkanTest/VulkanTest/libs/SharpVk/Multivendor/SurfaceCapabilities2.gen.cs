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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// Structure describing capabilities of a surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfaceCapabilities2
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MinImageCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D CurrentExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags? SupportedTransforms
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags CurrentTransform
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.CompositeAlphaFlags? SupportedCompositeAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageUsageFlags? SupportedUsageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitfield containing one bit set for each surface counter type
        /// supported.
        /// </summary>
        public SharpVk.Multivendor.SurfaceCounterFlags? SupportedSurfaceCounters
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe SurfaceCapabilities2 MarshalFrom(SharpVk.Interop.Multivendor.SurfaceCapabilities2* pointer)
        {
            SurfaceCapabilities2 result = default(SurfaceCapabilities2);
            result.MinImageCount = pointer->MinImageCount;
            result.MaxImageCount = pointer->MaxImageCount;
            result.CurrentExtent = pointer->CurrentExtent;
            result.MinImageExtent = pointer->MinImageExtent;
            result.MaxImageExtent = pointer->MaxImageExtent;
            result.MaxImageArrayLayers = pointer->MaxImageArrayLayers;
            result.SupportedTransforms = pointer->SupportedTransforms;
            result.CurrentTransform = pointer->CurrentTransform;
            result.SupportedCompositeAlpha = pointer->SupportedCompositeAlpha;
            result.SupportedUsageFlags = pointer->SupportedUsageFlags;
            result.SupportedSurfaceCounters = pointer->SupportedSurfaceCounters;
            return result;
        }
    }
}
