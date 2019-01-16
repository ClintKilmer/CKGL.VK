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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying parameters of the acquire.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AcquireNextImageInfo
    {
        /// <summary>
        /// The swapchain from which an image is being acquired.
        /// </summary>
        public SharpVk.Khronos.Swapchain Swapchain
        {
            get;
            set;
        }
        
        /// <summary>
        /// Indicates how long the function waits, in nanoseconds, if no image
        /// is available.
        /// </summary>
        public ulong Timeout
        {
            get;
            set;
        }
        
        /// <summary>
        /// Null or a semaphore to signal.
        /// </summary>
        public SharpVk.Semaphore Semaphore
        {
            get;
            set;
        }
        
        /// <summary>
        /// Null or a fence to signal.
        /// </summary>
        public SharpVk.Fence Fence
        {
            get;
            set;
        }
        
        /// <summary>
        /// A mask of physical devices for which the swapchain image will be
        /// ready to use when the semaphore or fence is signaled.
        /// </summary>
        public uint DeviceMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AcquireNextImageInfo* pointer)
        {
            pointer->SType = StructureType.AcquireNextImageInfo;
            pointer->Next = null;
            pointer->Swapchain = this.Swapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
            pointer->Timeout = this.Timeout;
            pointer->Semaphore = this.Semaphore?.handle ?? default(SharpVk.Interop.Semaphore);
            pointer->Fence = this.Fence?.handle ?? default(SharpVk.Interop.Fence);
            pointer->DeviceMask = this.DeviceMask;
        }
    }
}
