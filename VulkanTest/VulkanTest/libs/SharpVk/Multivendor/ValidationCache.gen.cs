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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ValidationCache
        : IDisposable
    {
        internal readonly SharpVk.Interop.Multivendor.ValidationCache handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal ValidationCache(SharpVk.Device parent, SharpVk.Interop.Multivendor.ValidationCache handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Multivendor.ValidationCache RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
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
                SharpVk.Interop.Multivendor.VkValidationCacheEXTDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyValidationCacheEXT;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceCaches">
        /// </param>
        public unsafe void MergeValidationCaches(ArrayProxy<SharpVk.Multivendor.ValidationCache>? sourceCaches)
        {
            try
            {
                SharpVk.Interop.Multivendor.ValidationCache* marshalledSourceCaches = default(SharpVk.Interop.Multivendor.ValidationCache*);
                if (sourceCaches.IsNull())
                {
                    marshalledSourceCaches = null;
                }
                else
                {
                    if (sourceCaches.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSourceCaches = (SharpVk.Interop.Multivendor.ValidationCache*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationCache>());
                        *(SharpVk.Interop.Multivendor.ValidationCache*)(marshalledSourceCaches) = sourceCaches.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Multivendor.ValidationCache);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.ValidationCache*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.ValidationCache>(Interop.HeapUtil.GetLength(sourceCaches.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sourceCaches.Value)); index++)
                        {
                            fieldPointer[index] = sourceCaches.Value[index]?.handle ?? default(SharpVk.Interop.Multivendor.ValidationCache);
                        }
                        marshalledSourceCaches = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkValidationCacheEXTMergeValidationCachesDelegate commandDelegate = commandCache.Cache.vkMergeValidationCachesEXT;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(sourceCaches)), marshalledSourceCaches);
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
        /// 
        /// </summary>
        public unsafe byte[] GetData()
        {
            try
            {
                byte[] result = default(byte[]);
                HostSize dataSize = default(HostSize);
                byte* marshalledData = default(byte*);
                SharpVk.Interop.Multivendor.VkValidationCacheEXTGetDataDelegate commandDelegate = commandCache.Cache.vkGetValidationCacheDataEXT;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &dataSize, marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>((uint)(dataSize)));
                commandDelegate(this.parent.handle, this.handle, &dataSize, marshalledData);
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)(dataSize)];
                    for(int index = 0; index < (uint)(dataSize); index++)
                    {
                        fieldPointer[index] = marshalledData[index];
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
        /// 
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
