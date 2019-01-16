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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="buffers">
        /// </param>
        /// <param name="offsets">
        /// </param>
        /// <param name="sizes">
        /// </param>
        public static unsafe void BindTransformFeedbackBuffers(this SharpVk.CommandBuffer extendedHandle, uint firstBinding, ArrayProxy<SharpVk.Buffer>? buffers, ArrayProxy<DeviceSize>? offsets, ArrayProxy<DeviceSize>? sizes = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledBuffers = default(SharpVk.Interop.Buffer*);
                DeviceSize* marshalledOffsets = default(DeviceSize*);
                DeviceSize* marshalledSizes = default(DeviceSize*);
                commandCache = extendedHandle.commandCache;
                if (buffers.IsNull())
                {
                    marshalledBuffers = null;
                }
                else
                {
                    if (buffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledBuffers) = buffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(buffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buffers.Value)); index++)
                        {
                            fieldPointer[index] = buffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledBuffers = fieldPointer;
                    }
                }
                if (offsets.IsNull())
                {
                    marshalledOffsets = null;
                }
                else
                {
                    if (offsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledOffsets = (DeviceSize*)(Interop.HeapUtil.Allocate<DeviceSize>());
                        *(DeviceSize*)(marshalledOffsets) = offsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(Interop.HeapUtil.GetLength(offsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(offsets.Value)); index++)
                        {
                            fieldPointer[index] = offsets.Value[index];
                        }
                        marshalledOffsets = fieldPointer;
                    }
                }
                if (sizes.IsNull())
                {
                    marshalledSizes = null;
                }
                else
                {
                    if (sizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSizes = (DeviceSize*)(Interop.HeapUtil.Allocate<DeviceSize>());
                        *(DeviceSize*)(marshalledSizes) = sizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(Interop.HeapUtil.GetLength(sizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(sizes.Value)); index++)
                        {
                            fieldPointer[index] = sizes.Value[index];
                        }
                        marshalledSizes = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBindTransformFeedbackBuffersDelegate commandDelegate = commandCache.Cache.vkCmdBindTransformFeedbackBuffersEXT;
                commandDelegate(extendedHandle.handle, firstBinding, (uint)(Interop.HeapUtil.GetLength(buffers)), marshalledBuffers, marshalledOffsets, marshalledSizes);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void BeginTransformFeedback(this SharpVk.CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<SharpVk.Buffer>? counterBuffers = null, ArrayProxy<DeviceSize>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default(SharpVk.Interop.Buffer*);
                DeviceSize* marshalledCounterBufferOffsets = default(DeviceSize*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (DeviceSize*)(Interop.HeapUtil.Allocate<DeviceSize>());
                        *(DeviceSize*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdBeginTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="counterBuffers">
        /// </param>
        /// <param name="counterBufferOffsets">
        /// </param>
        public static unsafe void EndTransformFeedback(this SharpVk.CommandBuffer extendedHandle, uint firstCounterBuffer, ArrayProxy<SharpVk.Buffer>? counterBuffers = null, ArrayProxy<DeviceSize>? counterBufferOffsets = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Buffer* marshalledCounterBuffers = default(SharpVk.Interop.Buffer*);
                DeviceSize* marshalledCounterBufferOffsets = default(DeviceSize*);
                commandCache = extendedHandle.commandCache;
                if (counterBuffers.IsNull())
                {
                    marshalledCounterBuffers = null;
                }
                else
                {
                    if (counterBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBuffers = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Buffer>());
                        *(SharpVk.Interop.Buffer*)(marshalledCounterBuffers) = counterBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Buffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Buffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Buffer>(Interop.HeapUtil.GetLength(counterBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBuffers.Value)); index++)
                        {
                            fieldPointer[index] = counterBuffers.Value[index]?.handle ?? default(SharpVk.Interop.Buffer);
                        }
                        marshalledCounterBuffers = fieldPointer;
                    }
                }
                if (counterBufferOffsets.IsNull())
                {
                    marshalledCounterBufferOffsets = null;
                }
                else
                {
                    if (counterBufferOffsets.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCounterBufferOffsets = (DeviceSize*)(Interop.HeapUtil.Allocate<DeviceSize>());
                        *(DeviceSize*)(marshalledCounterBufferOffsets) = counterBufferOffsets.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (DeviceSize*)(Interop.HeapUtil.AllocateAndClear<DeviceSize>(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(counterBufferOffsets.Value)); index++)
                        {
                            fieldPointer[index] = counterBufferOffsets.Value[index];
                        }
                        marshalledCounterBufferOffsets = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferEndTransformFeedbackDelegate commandDelegate = commandCache.Cache.vkCmdEndTransformFeedbackEXT;
                commandDelegate(extendedHandle.handle, firstCounterBuffer, (uint)(Interop.HeapUtil.GetLength(counterBuffers)), marshalledCounterBuffers, marshalledCounterBufferOffsets);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void BeginQueryIndexed(this SharpVk.CommandBuffer extendedHandle, SharpVk.QueryPool queryPool, uint query, uint index, SharpVk.QueryControlFlags? flags = default(SharpVk.QueryControlFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.QueryControlFlags marshalledFlags = default(SharpVk.QueryControlFlags);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.QueryControlFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdBeginQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, marshalledFlags, index);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void EndQueryIndexed(this SharpVk.CommandBuffer extendedHandle, SharpVk.QueryPool queryPool, uint query, uint index)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndQueryIndexedDelegate commandDelegate = commandCache.Cache.vkCmdEndQueryIndexedEXT;
                commandDelegate(extendedHandle.handle, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), query, index);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DrawIndirectByteCount(this SharpVk.CommandBuffer extendedHandle, uint instanceCount, uint firstInstance, SharpVk.Buffer counterBuffer, DeviceSize counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDrawIndirectByteCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectByteCountEXT;
                commandDelegate(extendedHandle.handle, instanceCount, firstInstance, counterBuffer?.handle ?? default(SharpVk.Interop.Buffer), counterBufferOffset, counterOffset, vertexStride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void BeginConditionalRendering(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Multivendor.ConditionalRenderingFlags? flags = default(SharpVk.Multivendor.ConditionalRenderingFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo* marshalledConditionalRenderingBegin = default(SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo*);
                void* nextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledConditionalRenderingBegin = (SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ConditionalRenderingBeginInfo>());
                marshalledConditionalRenderingBegin->SType = StructureType.ConditionalRenderingBeginInfo;
                marshalledConditionalRenderingBegin->Next = nextPointer;
                marshalledConditionalRenderingBegin->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledConditionalRenderingBegin->Offset = offset;
                if (flags != null)
                {
                    marshalledConditionalRenderingBegin->Flags = flags.Value;
                }
                else
                {
                    marshalledConditionalRenderingBegin->Flags = default(SharpVk.Multivendor.ConditionalRenderingFlags);
                }
                SharpVk.Interop.Multivendor.VkCommandBufferBeginConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdBeginConditionalRenderingEXT;
                commandDelegate(extendedHandle.handle, marshalledConditionalRenderingBegin);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void EndConditionalRendering(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndConditionalRenderingDelegate commandDelegate = commandCache.Cache.vkCmdEndConditionalRenderingEXT;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="discardRectangles">
        /// </param>
        public static unsafe void SetDiscardRectangle(this SharpVk.CommandBuffer extendedHandle, uint firstDiscardRectangle, ArrayProxy<SharpVk.Rect2D>? discardRectangles)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledDiscardRectangles = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (discardRectangles.IsNull())
                {
                    marshalledDiscardRectangles = null;
                }
                else
                {
                    if (discardRectangles.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDiscardRectangles = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>());
                        *(SharpVk.Rect2D*)(marshalledDiscardRectangles) = discardRectangles.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(Interop.HeapUtil.GetLength(discardRectangles.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(discardRectangles.Value)); index++)
                        {
                            fieldPointer[index] = discardRectangles.Value[index];
                        }
                        marshalledDiscardRectangles = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleDelegate commandDelegate = commandCache.Cache.vkCmdSetDiscardRectangleEXT;
                commandDelegate(extendedHandle.handle, firstDiscardRectangle, (uint)(Interop.HeapUtil.GetLength(discardRectangles)), marshalledDiscardRectangles);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferBeginDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void EndDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferEndDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdEndDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferInsertDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkCmdInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void SetSampleLocations(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.SampleLocationsInfo sampleLocationsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.SampleLocationsInfo* marshalledSampleLocationsInfo = default(SharpVk.Interop.Multivendor.SampleLocationsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSampleLocationsInfo = (SharpVk.Interop.Multivendor.SampleLocationsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SampleLocationsInfo>());
                sampleLocationsInfo.MarshalTo(marshalledSampleLocationsInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferSetSampleLocationsDelegate commandDelegate = commandCache.Cache.vkCmdSetSampleLocationsEXT;
                commandDelegate(extendedHandle.handle, marshalledSampleLocationsInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
