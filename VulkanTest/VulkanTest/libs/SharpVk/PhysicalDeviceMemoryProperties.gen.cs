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
    /// Structure specifying physical device memory properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceMemoryProperties
    {
        /// <summary>
        /// An array of MemoryType structures describing the _memory types_
        /// that can be used to access memory allocated from the heaps
        /// specified by memoryHeaps.
        /// </summary>
        public SharpVk.MemoryType[] MemoryTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of MemoryHeap structures describing the _memory heaps_
        /// from which memory can be allocated.
        /// </summary>
        public SharpVk.MemoryHeap[] MemoryHeaps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceMemoryProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceMemoryProperties* pointer)
        {
            PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);
            if (pointer->MemoryTypeCount != 0)
            {
                var fieldPointer = new SharpVk.MemoryType[(uint)(pointer->MemoryTypeCount)];
                for(int index = 0; index < (uint)(pointer->MemoryTypeCount); index++)
                {
                    fieldPointer[index] = (&(pointer->MemoryTypes_0))[index];
                }
                result.MemoryTypes = fieldPointer;
            }
            else
            {
                result.MemoryTypes = null;
            }
            if (pointer->MemoryHeapCount != 0)
            {
                var fieldPointer = new SharpVk.MemoryHeap[(uint)(pointer->MemoryHeapCount)];
                for(int index = 0; index < (uint)(pointer->MemoryHeapCount); index++)
                {
                    fieldPointer[index] = (&(pointer->MemoryHeaps_0))[index];
                }
                result.MemoryHeaps = fieldPointer;
            }
            else
            {
                result.MemoryHeaps = null;
            }
            return result;
        }
    }
}
