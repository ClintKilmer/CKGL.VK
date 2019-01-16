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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct BufferMemoryBarrier
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
        /// srcAccessMask defines a source access mask.
        /// </summary>
        public SharpVk.AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// dstAccessMask defines a destination access mask.
        /// </summary>
        public SharpVk.AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// The source queue family for a queue family ownership transfer.
        /// </summary>
        public uint SourceQueueFamilyIndex; 
        
        /// <summary>
        /// The destination queue family for a queue family ownership transfer.
        /// </summary>
        public uint DestinationQueueFamilyIndex; 
        
        /// <summary>
        /// A handle to the buffer whose backing memory is affected by the
        /// barrier.
        /// </summary>
        public SharpVk.Interop.Buffer Buffer; 
        
        /// <summary>
        /// An offset in bytes into the backing memory for buffer; this is
        /// relative to the base offset as bound to the buffer (see
        /// flink:vkBindBufferMemory).
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// A size in bytes of the affected area of backing memory for buffer,
        /// or Constants.WholeSize to use the range from offset to the end of
        /// the buffer.
        /// </summary>
        public DeviceSize Size; 
    }
}
