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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DisplayMode
    {
        internal readonly SharpVk.Interop.Khronos.DisplayMode handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.PhysicalDevice parent; 
        
        internal DisplayMode(SharpVk.PhysicalDevice parent, SharpVk.Interop.Khronos.DisplayMode handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Khronos.DisplayMode RawHandle => this.handle;
        
        /// <summary>
        /// Query capabilities of a mode and plane combination.
        /// </summary>
        public unsafe SharpVk.Khronos.DisplayPlaneCapabilities GetDisplayPlaneCapabilities(uint planeIndex)
        {
            try
            {
                SharpVk.Khronos.DisplayPlaneCapabilities result = default(SharpVk.Khronos.DisplayPlaneCapabilities);
                SharpVk.Khronos.DisplayPlaneCapabilities marshalledCapabilities = default(SharpVk.Khronos.DisplayPlaneCapabilities);
                SharpVk.Interop.Khronos.VkDisplayModeKHRGetDisplayPlaneCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneCapabilitiesKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, planeIndex, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledCapabilities;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
