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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Specify a dedicated memory allocation resource.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DedicatedAllocationMemoryAllocateInfo
    {
        /// <summary>
        /// image is null or a handle of an image which this memory will be
        /// bound to.
        /// </summary>
        public SharpVk.Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// buffer is null or a handle of a buffer which this memory will be
        /// bound to.
        /// </summary>
        public SharpVk.Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo* pointer)
        {
            pointer->SType = StructureType.DedicatedAllocationMemoryAllocateInfo;
            pointer->Next = null;
            pointer->Image = this.Image?.handle ?? default(SharpVk.Interop.Image);
            pointer->Buffer = this.Buffer?.handle ?? default(SharpVk.Interop.Buffer);
        }
    }
}
