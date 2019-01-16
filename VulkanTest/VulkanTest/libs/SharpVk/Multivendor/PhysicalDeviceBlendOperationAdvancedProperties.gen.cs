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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceBlendOperationAdvancedProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint AdvancedBlendMaxColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AdvancedBlendIndependentBlend
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AdvancedBlendNonPremultipliedSourceColor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AdvancedBlendNonPremultipliedDestinationColor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AdvancedBlendCorrelatedOverlap
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AdvancedBlendAllOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceBlendOperationAdvancedProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedProperties* pointer)
        {
            PhysicalDeviceBlendOperationAdvancedProperties result = default(PhysicalDeviceBlendOperationAdvancedProperties);
            result.AdvancedBlendMaxColorAttachments = pointer->AdvancedBlendMaxColorAttachments;
            result.AdvancedBlendIndependentBlend = pointer->AdvancedBlendIndependentBlend;
            result.AdvancedBlendNonPremultipliedSourceColor = pointer->AdvancedBlendNonPremultipliedSourceColor;
            result.AdvancedBlendNonPremultipliedDestinationColor = pointer->AdvancedBlendNonPremultipliedDestinationColor;
            result.AdvancedBlendCorrelatedOverlap = pointer->AdvancedBlendCorrelatedOverlap;
            result.AdvancedBlendAllOperations = pointer->AdvancedBlendAllOperations;
            return result;
        }
    }
}
