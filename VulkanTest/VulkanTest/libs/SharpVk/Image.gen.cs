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
    /// Opaque handle to a image object.
    /// </summary>
    public partial class Image
        : IDisposable
    {
        internal readonly SharpVk.Interop.Image handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal Image(SharpVk.Device parent, SharpVk.Interop.Image handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Image RawHandle => this.handle;
        
        /// <summary>
        /// Bind device memory to an image object.
        /// </summary>
        public unsafe void BindMemory(SharpVk.DeviceMemory memory, DeviceSize memoryOffset)
        {
            try
            {
                SharpVk.Interop.VkImageBindMemoryDelegate commandDelegate = commandCache.Cache.vkBindImageMemory;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, memory?.handle ?? default(SharpVk.Interop.DeviceMemory), memoryOffset);
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
        /// Returns the memory requirements for specified Vulkan object.
        /// </summary>
        public unsafe SharpVk.MemoryRequirements GetMemoryRequirements()
        {
            try
            {
                SharpVk.MemoryRequirements result = default(SharpVk.MemoryRequirements);
                SharpVk.MemoryRequirements marshalledMemoryRequirements = default(SharpVk.MemoryRequirements);
                SharpVk.Interop.VkImageGetMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetImageMemoryRequirements;
                commandDelegate(this.parent.handle, this.handle, &marshalledMemoryRequirements);
                result = marshalledMemoryRequirements;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query the memory requirements for a sparse image.
        /// </summary>
        public unsafe SharpVk.SparseImageMemoryRequirements[] GetSparseMemoryRequirements()
        {
            try
            {
                SharpVk.SparseImageMemoryRequirements[] result = default(SharpVk.SparseImageMemoryRequirements[]);
                uint sparseMemoryRequirementCount = default(uint);
                SharpVk.SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = default(SharpVk.SparseImageMemoryRequirements*);
                SharpVk.Interop.VkImageGetSparseMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetImageSparseMemoryRequirements;
                commandDelegate(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SharpVk.SparseImageMemoryRequirements*)(Interop.HeapUtil.Allocate<SharpVk.SparseImageMemoryRequirements>((uint)(sparseMemoryRequirementCount)));
                commandDelegate(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SharpVk.SparseImageMemoryRequirements[(uint)(sparseMemoryRequirementCount)];
                    for(int index = 0; index < (uint)(sparseMemoryRequirementCount); index++)
                    {
                        fieldPointer[index] = marshalledSparseMemoryRequirements[index];
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
        /// Destroy an image object.
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
                SharpVk.Interop.VkImageDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyImage;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve information about an image subresource.
        /// </summary>
        public unsafe SharpVk.SubresourceLayout GetSubresourceLayout(SharpVk.ImageSubresource subresource)
        {
            try
            {
                SharpVk.SubresourceLayout result = default(SharpVk.SubresourceLayout);
                SharpVk.ImageSubresource* marshalledSubresource = default(SharpVk.ImageSubresource*);
                SharpVk.SubresourceLayout marshalledLayout = default(SharpVk.SubresourceLayout);
                marshalledSubresource = (SharpVk.ImageSubresource*)(Interop.HeapUtil.Allocate<SharpVk.ImageSubresource>());
                *marshalledSubresource = subresource;
                SharpVk.Interop.VkImageGetSubresourceLayoutDelegate commandDelegate = commandCache.Cache.vkGetImageSubresourceLayout;
                commandDelegate(this.parent.handle, this.handle, marshalledSubresource, &marshalledLayout);
                result = marshalledLayout;
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
