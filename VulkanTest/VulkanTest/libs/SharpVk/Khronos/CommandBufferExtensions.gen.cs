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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Pushes descriptor updates into a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="descriptorWrites">
        /// </param>
        public static unsafe void PushDescriptorSet(this SharpVk.CommandBuffer extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout layout, uint set, ArrayProxy<SharpVk.WriteDescriptorSet>? descriptorWrites)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(SharpVk.Interop.WriteDescriptorSet*);
                commandCache = extendedHandle.commandCache;
                if (descriptorWrites.IsNull())
                {
                    marshalledDescriptorWrites = null;
                }
                else
                {
                    if (descriptorWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorWrites = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.WriteDescriptorSet>());
                        descriptorWrites.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.WriteDescriptorSet*)(marshalledDescriptorWrites));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(Interop.HeapUtil.GetLength(descriptorWrites.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorWrites.Value)); index++)
                        {
                            descriptorWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDescriptorWrites = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetDelegate commandDelegate = commandCache.Cache.vkCmdPushDescriptorSetKHR;
                commandDelegate(extendedHandle.handle, pipelineBindPoint, layout?.handle ?? default(SharpVk.Interop.PipelineLayout), set, (uint)(Interop.HeapUtil.GetLength(descriptorWrites)), marshalledDescriptorWrites);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Pushes descriptor updates into a command buffer using a descriptor
        /// update template.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void PushDescriptorSetWithTemplate(this SharpVk.CommandBuffer extendedHandle, SharpVk.DescriptorUpdateTemplate descriptorUpdateTemplate, SharpVk.PipelineLayout layout, uint set, IntPtr data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferPushDescriptorSetWithTemplateDelegate commandDelegate = commandCache.Cache.vkCmdPushDescriptorSetWithTemplateKHR;
                commandDelegate(extendedHandle.handle, descriptorUpdateTemplate?.handle ?? default(SharpVk.Interop.DescriptorUpdateTemplate), layout?.handle ?? default(SharpVk.Interop.PipelineLayout), set, data.ToPointer());
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
        public static unsafe void BeginRenderPass2(this SharpVk.CommandBuffer extendedHandle, SharpVk.RenderPassBeginInfo renderPassBegin, SharpVk.SubpassContents contents)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.RenderPassBeginInfo* marshalledRenderPassBegin = default(SharpVk.Interop.RenderPassBeginInfo*);
                SharpVk.Interop.Khronos.SubpassBeginInfo* marshalledSubpassBeginInfo = default(SharpVk.Interop.Khronos.SubpassBeginInfo*);
                void* nextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                marshalledRenderPassBegin = (SharpVk.Interop.RenderPassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassBeginInfo>());
                renderPassBegin.MarshalTo(marshalledRenderPassBegin);
                marshalledSubpassBeginInfo = (SharpVk.Interop.Khronos.SubpassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SubpassBeginInfo>());
                marshalledSubpassBeginInfo->SType = StructureType.SubpassBeginInfo;
                marshalledSubpassBeginInfo->Next = nextPointer;
                marshalledSubpassBeginInfo->Contents = contents;
                SharpVk.Interop.Khronos.VkCommandBufferBeginRenderPass2Delegate commandDelegate = commandCache.Cache.vkCmdBeginRenderPass2KHR;
                commandDelegate(extendedHandle.handle, marshalledRenderPassBegin, marshalledSubpassBeginInfo);
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
        public static unsafe void NextSubpass2(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.SubpassBeginInfo subpassBeginInfo, SharpVk.Khronos.SubpassEndInfo subpassEndInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SubpassBeginInfo* marshalledSubpassBeginInfo = default(SharpVk.Interop.Khronos.SubpassBeginInfo*);
                SharpVk.Interop.Khronos.SubpassEndInfo* marshalledSubpassEndInfo = default(SharpVk.Interop.Khronos.SubpassEndInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSubpassBeginInfo = (SharpVk.Interop.Khronos.SubpassBeginInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SubpassBeginInfo>());
                subpassBeginInfo.MarshalTo(marshalledSubpassBeginInfo);
                marshalledSubpassEndInfo = (SharpVk.Interop.Khronos.SubpassEndInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SubpassEndInfo>());
                subpassEndInfo.MarshalTo(marshalledSubpassEndInfo);
                SharpVk.Interop.Khronos.VkCommandBufferNextSubpass2Delegate commandDelegate = commandCache.Cache.vkCmdNextSubpass2KHR;
                commandDelegate(extendedHandle.handle, marshalledSubpassBeginInfo, marshalledSubpassEndInfo);
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
        public static unsafe void EndRenderPass2(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SubpassEndInfo* subpassEndInfo = default(SharpVk.Interop.Khronos.SubpassEndInfo*);
                void* nextPointer = default(void*);
                commandCache = extendedHandle.commandCache;
                subpassEndInfo = (SharpVk.Interop.Khronos.SubpassEndInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SubpassEndInfo>());
                subpassEndInfo->SType = StructureType.SubpassEndInfo;
                subpassEndInfo->Next = nextPointer;
                SharpVk.Interop.Khronos.VkCommandBufferEndRenderPass2Delegate commandDelegate = commandCache.Cache.vkCmdEndRenderPass2KHR;
                commandDelegate(extendedHandle.handle, subpassEndInfo);
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
        public static unsafe void DrawIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferDrawIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndirectCountKHR;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, countBuffer?.handle ?? default(SharpVk.Interop.Buffer), countBufferOffset, maxDrawCount, stride);
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
        public static unsafe void DrawIndexedIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferDrawIndexedIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawIndexedIndirectCountKHR;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, countBuffer?.handle ?? default(SharpVk.Interop.Buffer), countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
