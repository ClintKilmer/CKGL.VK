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
    /// Structure specifying a mapped memory range.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MappedMemoryRange
    {
        /// <summary>
        /// The memory object to which this range belongs.
        /// </summary>
        public SharpVk.DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// The zero-based byte offset from the beginning of the memory object.
        /// </summary>
        public DeviceSize Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// size is either the size of range, or Constants.WholeSize to affect
        /// the range from offset to the end of the current mapping of the
        /// allocation.
        /// </summary>
        public DeviceSize Size
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.MappedMemoryRange* pointer)
        {
            pointer->SType = StructureType.MappedMemoryRange;
            pointer->Next = null;
            pointer->Memory = this.Memory?.handle ?? default(SharpVk.Interop.DeviceMemory);
            pointer->Offset = this.Offset;
            pointer->Size = this.Size;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe MappedMemoryRange MarshalFrom(SharpVk.Interop.MappedMemoryRange* pointer)
        {
            MappedMemoryRange result = default(MappedMemoryRange);
            result.Memory = new SharpVk.DeviceMemory(default(SharpVk.Device), pointer->Memory);
            result.Offset = pointer->Offset;
            result.Size = pointer->Size;
            return result;
        }
    }
}
