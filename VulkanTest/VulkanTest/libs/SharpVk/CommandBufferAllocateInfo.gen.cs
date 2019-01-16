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
    /// Structure specifying the allocation parameters for command buffer
    /// object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CommandBufferAllocateInfo
    {
        /// <summary>
        /// The command pool from which the command buffers are allocated.
        /// </summary>
        public SharpVk.CommandPool CommandPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// level determines whether the command buffers are primary or
        /// secondary command buffers. Possible values include: + --
        /// </summary>
        public SharpVk.CommandBufferLevel Level
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandBufferCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.CommandBufferAllocateInfo* pointer)
        {
            pointer->SType = StructureType.CommandBufferAllocateInfo;
            pointer->Next = null;
            pointer->CommandPool = this.CommandPool?.handle ?? default(SharpVk.Interop.CommandPool);
            pointer->Level = this.Level;
            pointer->CommandBufferCount = this.CommandBufferCount;
        }
    }
}
