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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying descriptor buffer info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DescriptorBufferInfo
    {
        /// <summary>
        /// The buffer resource.
        /// </summary>
        public SharpVk.Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The offset in bytes from the start of buffer. Access to buffer
        /// memory via this descriptor uses addressing that is relative to this
        /// starting offset.
        /// </summary>
        public DeviceSize Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The size in bytes that is used for this descriptor update, or
        /// Constants.WholeSize to use the range from offset to the end of the
        /// buffer. + -- [NOTE] .Note ==== When using Constants.WholeSize, the
        /// effective range must not be larger than the maximum range for the
        /// descriptor type (maxUniformBufferRange or maxStorageBufferRange).
        /// This means that Constants.WholeSize is not typically useful in the
        /// common case where uniform buffer descriptors are suballocated from
        /// a buffer that is much larger than maxUniformBufferRange. ==== -- +
        /// For DescriptorType.UniformBufferDynamic and
        /// DescriptorType.StorageBufferDynamic descriptor types, offset is the
        /// base offset from which the dynamic offset is applied and range is
        /// the static size used for all dynamic offsets.
        /// </summary>
        public DeviceSize Range
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.DescriptorBufferInfo* pointer)
        {
            pointer->Buffer = this.Buffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->Offset = this.Offset;
            pointer->Range = this.Range;
        }
    }
}
