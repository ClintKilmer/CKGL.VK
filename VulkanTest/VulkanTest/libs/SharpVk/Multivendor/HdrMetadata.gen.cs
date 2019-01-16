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
    public partial struct HdrMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.XYColor DisplayPrimaryRed
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.XYColor DisplayPrimaryGreen
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.XYColor DisplayPrimaryBlue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.XYColor WhitePoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLuminance
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLuminance
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxContentLightLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxFrameAverageLightLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.HdrMetadata* pointer)
        {
            pointer->SType = StructureType.HdrMetadata;
            pointer->Next = null;
            pointer->DisplayPrimaryRed = this.DisplayPrimaryRed;
            pointer->DisplayPrimaryGreen = this.DisplayPrimaryGreen;
            pointer->DisplayPrimaryBlue = this.DisplayPrimaryBlue;
            pointer->WhitePoint = this.WhitePoint;
            pointer->MaxLuminance = this.MaxLuminance;
            pointer->MinLuminance = this.MinLuminance;
            pointer->MaxContentLightLevel = this.MaxContentLightLevel;
            pointer->MaxFrameAverageLightLevel = this.MaxFrameAverageLightLevel;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe HdrMetadata MarshalFrom(SharpVk.Interop.Multivendor.HdrMetadata* pointer)
        {
            HdrMetadata result = default(HdrMetadata);
            result.DisplayPrimaryRed = pointer->DisplayPrimaryRed;
            result.DisplayPrimaryGreen = pointer->DisplayPrimaryGreen;
            result.DisplayPrimaryBlue = pointer->DisplayPrimaryBlue;
            result.WhitePoint = pointer->WhitePoint;
            result.MaxLuminance = pointer->MaxLuminance;
            result.MinLuminance = pointer->MinLuminance;
            result.MaxContentLightLevel = pointer->MaxContentLightLevel;
            result.MaxFrameAverageLightLevel = pointer->MaxFrameAverageLightLevel;
            return result;
        }
    }
}
