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
    /// Structure describing an available display device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DisplayProperties
    {
        /// <summary>
        /// A handle that is used to refer to the display described here. This
        /// handle will be valid for the lifetime of the Vulkan instance.
        /// </summary>
        public SharpVk.Khronos.Display Display
        {
            get;
            set;
        }
        
        /// <summary>
        /// A string containing the name of the display. Generally, this will
        /// be the name provided by the display's EDID. It can be Null if no
        /// suitable name is available.
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }
        
        /// <summary>
        /// physicalDimensions describes the physical width and height of the
        /// visible portion of the display, in millimeters.
        /// </summary>
        public SharpVk.Extent2D PhysicalDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// physicalResolution describes the physical, native, or preferred
        /// resolution of the display.
        /// </summary>
        public SharpVk.Extent2D PhysicalResolution
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
        public bool PlaneReorderPossible
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PersistentContent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe DisplayProperties MarshalFrom(SharpVk.Interop.Khronos.DisplayProperties* pointer)
        {
            DisplayProperties result = default(DisplayProperties);
            result.Display = new SharpVk.Khronos.Display(pointer->Display);
            result.DisplayName = Interop.HeapUtil.MarshalStringFrom(pointer->DisplayName);
            result.PhysicalDimensions = pointer->PhysicalDimensions;
            result.PhysicalResolution = pointer->PhysicalResolution;
            result.SupportedTransforms = pointer->SupportedTransforms;
            result.PlaneReorderPossible = pointer->PlaneReorderPossible;
            result.PersistentContent = pointer->PersistentContent;
            return result;
        }
    }
}
