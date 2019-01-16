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
    /// Opaque handle to a query pool object.
    /// </summary>
    public partial class QueryPool
        : IDisposable
    {
        internal readonly SharpVk.Interop.QueryPool handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal QueryPool(SharpVk.Device parent, SharpVk.Interop.QueryPool handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.QueryPool RawHandle => this.handle;
        
        /// <summary>
        /// Destroy a query pool object.
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
                SharpVk.Interop.VkQueryPoolDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyQueryPool;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Copy results of queries in a query pool to a host memory region.
        /// </summary>
        /// <param name="data">
        /// </param>
        public unsafe Result GetResults(uint firstQuery, uint queryCount, ArrayProxy<byte>? data, DeviceSize stride, SharpVk.QueryResultFlags? flags = default(SharpVk.QueryResultFlags?))
        {
            try
            {
                Result result = default(Result);
                byte* marshalledData = default(byte*);
                SharpVk.QueryResultFlags marshalledFlags = default(SharpVk.QueryResultFlags);
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledData) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledData = fieldPointer;
                    }
                }
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.QueryResultFlags);
                }
                SharpVk.Interop.VkQueryPoolGetResultsDelegate commandDelegate = commandCache.Cache.vkGetQueryPoolResults;
                result = commandDelegate(this.parent.handle, this.handle, firstQuery, queryCount, (HostSize)(Interop.HeapUtil.GetLength(data)), marshalledData, stride, marshalledFlags);
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
