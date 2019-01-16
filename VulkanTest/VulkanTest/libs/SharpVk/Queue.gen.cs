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
    /// Opaque handle to a queue object.
    /// </summary>
    public partial class Queue
    {
        internal readonly SharpVk.Interop.Queue handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal Queue(SharpVk.Device parent, SharpVk.Interop.Queue handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Queue RawHandle => this.handle;
        
        /// <summary>
        /// Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        /// <param name="submits">
        /// </param>
        public unsafe void Submit(ArrayProxy<SharpVk.SubmitInfo>? submits, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.SubmitInfo* marshalledSubmits = default(SharpVk.Interop.SubmitInfo*);
                if (submits.IsNull())
                {
                    marshalledSubmits = null;
                }
                else
                {
                    if (submits.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo>());
                        submits.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubmitInfo*)(marshalledSubmits));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubmitInfo>(Interop.HeapUtil.GetLength(submits.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(submits.Value)); index++)
                        {
                            submits.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueSubmitDelegate commandDelegate = commandCache.Cache.vkQueueSubmit;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(submits)), marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// Wait for a queue to become idle.
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                SharpVk.Interop.VkQueueWaitIdleDelegate commandDelegate = commandCache.Cache.vkQueueWaitIdle;
                Result methodResult = commandDelegate(this.handle);
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
        /// Bind device memory to a sparse resource object.
        /// </summary>
        /// <param name="bindInfo">
        /// </param>
        public unsafe void BindSparse(ArrayProxy<SharpVk.BindSparseInfo>? bindInfo, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.BindSparseInfo* marshalledBindInfo = default(SharpVk.Interop.BindSparseInfo*);
                if (bindInfo.IsNull())
                {
                    marshalledBindInfo = null;
                }
                else
                {
                    if (bindInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfo = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindSparseInfo>());
                        bindInfo.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindSparseInfo*)(marshalledBindInfo));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindSparseInfo>(Interop.HeapUtil.GetLength(bindInfo.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfo.Value)); index++)
                        {
                            bindInfo.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfo = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueBindSparseDelegate commandDelegate = commandCache.Cache.vkQueueBindSparse;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(bindInfo)), marshalledBindInfo, fence?.handle ?? default(SharpVk.Interop.Fence));
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
    }
}
