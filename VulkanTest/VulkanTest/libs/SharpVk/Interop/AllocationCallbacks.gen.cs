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
    public unsafe partial struct AllocationCallbacks
    {
        /// <summary>
        /// A value to be interpreted by the implementation of the callbacks.
        /// When any of the callbacks in AllocationCallbacks are called, the
        /// Vulkan implementation will pass this value as the first parameter
        /// to the callback. This value can vary each time an allocator is
        /// passed into a command, even when the same object takes an allocator
        /// in multiple commands.
        /// </summary>
        public void* UserData; 
        
        /// <summary>
        /// An application-defined memory allocation function of type
        /// AllocationFunction.
        /// </summary>
        public IntPtr Allocation; 
        
        /// <summary>
        /// An application-defined memory reallocation function of type
        /// ReallocationFunction.
        /// </summary>
        public IntPtr Reallocation; 
        
        /// <summary>
        /// An application-defined memory free function of type FreeFunction.
        /// </summary>
        public IntPtr Free; 
        
        /// <summary>
        /// An application-defined function that is called by the
        /// implementation when the implementation makes internal allocations,
        /// and it is of type InternalAllocationNotification.
        /// </summary>
        public IntPtr InternalAllocation; 
        
        /// <summary>
        /// An application-defined function that is called by the
        /// implementation when the implementation frees internal allocations,
        /// and it is of type InternalFreeNotification.
        /// </summary>
        public IntPtr InternalFree; 
    }
}
