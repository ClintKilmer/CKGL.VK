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
    public unsafe partial struct SparseMemoryBind
    {
        /// <summary>
        /// The offset into the resource.
        /// </summary>
        public DeviceSize ResourceOffset; 
        
        /// <summary>
        /// The size of the memory region to be bound.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// The DeviceMemory object that the range of the resource is bound to.
        /// If memory is null, the range is unbound.
        /// </summary>
        public SharpVk.Interop.DeviceMemory Memory; 
        
        /// <summary>
        /// The offset into the DeviceMemory object to bind the resource range
        /// to. If memory is null, this value is ignored.
        /// </summary>
        public DeviceSize MemoryOffset; 
        
        /// <summary>
        /// A bitmask specifying usage of the binding operation. Bits which can
        /// be set include: + --
        /// </summary>
        public SharpVk.SparseMemoryBindFlags Flags; 
    }
}
