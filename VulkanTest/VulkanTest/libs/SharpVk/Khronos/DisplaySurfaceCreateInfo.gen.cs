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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying parameters of a newly created display plane
    /// surface object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// Reserved for future use, and must be zero.
        /// </summary>
        public SharpVk.Khronos.DisplaySurfaceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// The mode to use when displaying this surface.
        /// </summary>
        public SharpVk.Khronos.DisplayMode DisplayMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// The plane on which this surface appears.
        /// </summary>
        public uint PlaneIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// The z-order of the plane.
        /// </summary>
        public uint PlaneStackIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// The transform to apply to the images as part of the scanout
        /// operation.
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// The global alpha value. This value is ignored if alphaMode is not
        /// VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </summary>
        public float GlobalAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// The type of alpha blending to use.
        /// </summary>
        public SharpVk.Khronos.DisplayPlaneAlphaFlags AlphaMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D ImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DisplaySurfaceCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.DisplaySurfaceCreateFlags);
            }
            pointer->DisplayMode = this.DisplayMode?.handle ?? default(SharpVk.Interop.Khronos.DisplayMode);
            pointer->PlaneIndex = this.PlaneIndex;
            pointer->PlaneStackIndex = this.PlaneStackIndex;
            pointer->Transform = this.Transform;
            pointer->GlobalAlpha = this.GlobalAlpha;
            pointer->AlphaMode = this.AlphaMode;
            pointer->ImageExtent = this.ImageExtent;
        }
    }
}
