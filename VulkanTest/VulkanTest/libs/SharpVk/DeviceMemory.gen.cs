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
    /// Opaque handle to a device memory object.
    /// </summary>
    public partial class DeviceMemory
    {
        internal readonly SharpVk.Interop.DeviceMemory handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal DeviceMemory(SharpVk.Device parent, SharpVk.Interop.DeviceMemory handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.DeviceMemory RawHandle => this.handle;
        
        /// <summary>
        /// Free GPU memory.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Free(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
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
                SharpVk.Interop.VkDeviceMemoryFreeDelegate commandDelegate = commandCache.Cache.vkFreeMemory;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Map a memory object into application address space.
        /// </summary>
        public unsafe IntPtr Map(DeviceSize offset, DeviceSize size, SharpVk.MemoryMapFlags? flags = default(SharpVk.MemoryMapFlags?))
        {
            try
            {
                IntPtr result = default(IntPtr);
                SharpVk.MemoryMapFlags marshalledFlags = default(SharpVk.MemoryMapFlags);
                void* marshalledData = default(void*);
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.MemoryMapFlags);
                }
                SharpVk.Interop.VkDeviceMemoryMapDelegate commandDelegate = commandCache.Cache.vkMapMemory;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, offset, size, marshalledFlags, &marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new IntPtr(marshalledData);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Unmap a previously mapped memory object.
        /// </summary>
        public unsafe void Unmap()
        {
            try
            {
                SharpVk.Interop.VkDeviceMemoryUnmapDelegate commandDelegate = commandCache.Cache.vkUnmapMemory;
                commandDelegate(this.parent.handle, this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the current commitment for a DeviceMemory.
        /// </summary>
        public unsafe DeviceSize GetCommitment()
        {
            try
            {
                DeviceSize result = default(DeviceSize);
                DeviceSize marshalledCommittedMemoryInBytes = default(DeviceSize);
                SharpVk.Interop.VkDeviceMemoryGetCommitmentDelegate commandDelegate = commandCache.Cache.vkGetDeviceMemoryCommitment;
                commandDelegate(this.parent.handle, this.handle, &marshalledCommittedMemoryInBytes);
                result = marshalledCommittedMemoryInBytes;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
