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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Swapchain
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.Swapchain handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal Swapchain(SharpVk.Device parent, SharpVk.Interop.Khronos.Swapchain handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Khronos.Swapchain RawHandle => this.handle;
        
        /// <summary>
        /// Destroy a swapchain object.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkSwapchainKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroySwapchainKHR;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Obtain the array of presentable images associated with a swapchain.
        /// </summary>
        public unsafe SharpVk.Image[] GetImages()
        {
            try
            {
                SharpVk.Image[] result = default(SharpVk.Image[]);
                uint swapchainImageCount = default(uint);
                SharpVk.Interop.Image* marshalledSwapchainImages = default(SharpVk.Interop.Image*);
                SharpVk.Interop.Khronos.VkSwapchainKHRGetImagesDelegate commandDelegate = commandCache.Cache.vkGetSwapchainImagesKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &swapchainImageCount, marshalledSwapchainImages);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSwapchainImages = (SharpVk.Interop.Image*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Image>((uint)(swapchainImageCount)));
                commandDelegate(this.parent.handle, this.handle, &swapchainImageCount, marshalledSwapchainImages);
                if (marshalledSwapchainImages != null)
                {
                    var fieldPointer = new SharpVk.Image[(uint)(swapchainImageCount)];
                    for(int index = 0; index < (uint)(swapchainImageCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Image(this.parent, marshalledSwapchainImages[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="timeout">
        /// Indicates how long the function waits, in nanoseconds, if no image
        /// is available.
        /// </param>
        /// <param name="semaphore">
        /// Null or a semaphore to signal.
        /// </param>
        /// <param name="fence">
        /// Null or a fence to signal.
        /// </param>
        public unsafe uint AcquireNextImage(ulong timeout, SharpVk.Semaphore semaphore, SharpVk.Fence fence)
        {
            try
            {
                uint result = default(uint);
                uint marshalledImageIndex = default(uint);
                SharpVk.Interop.Khronos.VkSwapchainKHRAcquireNextImageDelegate commandDelegate = commandCache.Cache.vkAcquireNextImageKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, timeout, semaphore?.handle ?? default(SharpVk.Interop.Semaphore), fence?.handle ?? default(SharpVk.Interop.Fence), &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Result GetStatus()
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.VkSwapchainKHRGetStatusDelegate commandDelegate = commandCache.Cache.vkGetSwapchainStatusKHR;
                result = commandDelegate(this.parent.handle, this.handle);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
