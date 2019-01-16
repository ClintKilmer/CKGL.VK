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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a command pool object.
    /// </summary>
    public partial class CommandPool
        : IDisposable
    {
        internal readonly SharpVk.Interop.CommandPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal CommandPool(SharpVk.Device parent, SharpVk.Interop.CommandPool handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.CommandPool RawHandle => this.handle;
        
        /// <summary>
        /// Destroy a command pool object.
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
                SharpVk.Interop.VkCommandPoolDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyCommandPool;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reset a command pool.
        /// </summary>
        public unsafe void Reset(SharpVk.CommandPoolResetFlags? flags = default(SharpVk.CommandPoolResetFlags?))
        {
            try
            {
                SharpVk.CommandPoolResetFlags marshalledFlags = default(SharpVk.CommandPoolResetFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.CommandPoolResetFlags);
                }
                SharpVk.Interop.VkCommandPoolResetDelegate commandDelegate = commandCache.Cache.vkResetCommandPool;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, marshalledFlags);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Free command buffers.
        /// </summary>
        /// <param name="commandBuffers">
        /// </param>
        public unsafe void FreeCommandBuffers(ArrayProxy<SharpVk.CommandBuffer>? commandBuffers)
        {
            try
            {
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                if (commandBuffers.IsNull())
                {
                    marshalledCommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>());
                        *(SharpVk.Interop.CommandBuffer*)(marshalledCommandBuffers) = commandBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.CommandBuffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(Interop.HeapUtil.GetLength(commandBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBuffers.Value)); index++)
                        {
                            fieldPointer[index] = commandBuffers.Value[index]?.handle ?? default(SharpVk.Interop.CommandBuffer);
                        }
                        marshalledCommandBuffers = fieldPointer;
                    }
                }
                SharpVk.Interop.VkCommandPoolFreeCommandBuffersDelegate commandDelegate = commandCache.Cache.vkFreeCommandBuffers;
                commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(commandBuffers)), marshalledCommandBuffers);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Trim(SharpVk.CommandPoolTrimFlags? flags = default(SharpVk.CommandPoolTrimFlags?))
        {
            try
            {
                SharpVk.CommandPoolTrimFlags marshalledFlags = default(SharpVk.CommandPoolTrimFlags);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.CommandPoolTrimFlags);
                }
                SharpVk.Interop.VkCommandPoolTrimDelegate commandDelegate = commandCache.Cache.vkTrimCommandPool;
                commandDelegate(this.parent.handle, this.handle, marshalledFlags);
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
