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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// Reserved for future use, and must be zero.
        /// </summary>
        public SharpVk.Khronos.DisplaySurfaceCreateFlags Flags; 
        
        /// <summary>
        /// The mode to use when displaying this surface.
        /// </summary>
        public SharpVk.Interop.Khronos.DisplayMode DisplayMode; 
        
        /// <summary>
        /// The plane on which this surface appears.
        /// </summary>
        public uint PlaneIndex; 
        
        /// <summary>
        /// The z-order of the plane.
        /// </summary>
        public uint PlaneStackIndex; 
        
        /// <summary>
        /// The transform to apply to the images as part of the scanout
        /// operation.
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags Transform; 
        
        /// <summary>
        /// The global alpha value. This value is ignored if alphaMode is not
        /// VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </summary>
        public float GlobalAlpha; 
        
        /// <summary>
        /// The type of alpha blending to use.
        /// </summary>
        public SharpVk.Khronos.DisplayPlaneAlphaFlags AlphaMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D ImageExtent; 
    }
}
