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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Set the viewport W scaling on a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="viewportWScalings">
        /// </param>
        public static unsafe void SetViewportWScaling(this SharpVk.CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<SharpVk.NVidia.ViewportWScaling>? viewportWScalings)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.NVidia.ViewportWScaling* marshalledViewportWScalings = default(SharpVk.NVidia.ViewportWScaling*);
                commandCache = extendedHandle.commandCache;
                if (viewportWScalings.IsNull())
                {
                    marshalledViewportWScalings = null;
                }
                else
                {
                    if (viewportWScalings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledViewportWScalings = (SharpVk.NVidia.ViewportWScaling*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.ViewportWScaling>());
                        *(SharpVk.NVidia.ViewportWScaling*)(marshalledViewportWScalings) = viewportWScalings.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.ViewportWScaling*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.ViewportWScaling>(Interop.HeapUtil.GetLength(viewportWScalings.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(viewportWScalings.Value)); index++)
                        {
                            fieldPointer[index] = viewportWScalings.Value[index];
                        }
                        marshalledViewportWScalings = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportWScalingDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportWScalingNV;
                commandDelegate(extendedHandle.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(viewportWScalings)), marshalledViewportWScalings);
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
        public static unsafe void BindShadingRateImage(this SharpVk.CommandBuffer extendedHandle, SharpVk.ImageView imageView, SharpVk.ImageLayout imageLayout)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferBindShadingRateImageDelegate commandDelegate = commandCache.Cache.vkCmdBindShadingRateImageNV;
                commandDelegate(extendedHandle.handle, imageView?.handle ?? default(SharpVk.Interop.ImageView), imageLayout);
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
        /// <param name="shadingRatePalettes">
        /// </param>
        public static unsafe void SetViewportShadingRatePalette(this SharpVk.CommandBuffer extendedHandle, uint firstViewport, ArrayProxy<SharpVk.NVidia.ShadingRatePalette>? shadingRatePalettes)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.ShadingRatePalette* marshalledShadingRatePalettes = default(SharpVk.Interop.NVidia.ShadingRatePalette*);
                commandCache = extendedHandle.commandCache;
                if (shadingRatePalettes.IsNull())
                {
                    marshalledShadingRatePalettes = null;
                }
                else
                {
                    if (shadingRatePalettes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledShadingRatePalettes = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ShadingRatePalette>());
                        shadingRatePalettes.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.ShadingRatePalette*)(marshalledShadingRatePalettes));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.ShadingRatePalette*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.ShadingRatePalette>(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes.Value)); index++)
                        {
                            shadingRatePalettes.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledShadingRatePalettes = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetViewportShadingRatePaletteDelegate commandDelegate = commandCache.Cache.vkCmdSetViewportShadingRatePaletteNV;
                commandDelegate(extendedHandle.handle, firstViewport, (uint)(Interop.HeapUtil.GetLength(shadingRatePalettes)), marshalledShadingRatePalettes);
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
        /// <param name="customSampleOrders">
        /// </param>
        public static unsafe void SetCoarseSampleOrder(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.CoarseSampleOrderType sampleOrderType, ArrayProxy<SharpVk.NVidia.CoarseSampleOrderCustom>? customSampleOrders)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CoarseSampleOrderCustom* marshalledCustomSampleOrders = default(SharpVk.Interop.NVidia.CoarseSampleOrderCustom*);
                commandCache = extendedHandle.commandCache;
                if (customSampleOrders.IsNull())
                {
                    marshalledCustomSampleOrders = null;
                }
                else
                {
                    if (customSampleOrders.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCustomSampleOrders = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>());
                        customSampleOrders.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(marshalledCustomSampleOrders));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.CoarseSampleOrderCustom*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.CoarseSampleOrderCustom>(Interop.HeapUtil.GetLength(customSampleOrders.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(customSampleOrders.Value)); index++)
                        {
                            customSampleOrders.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCustomSampleOrders = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetCoarseSampleOrderDelegate commandDelegate = commandCache.Cache.vkCmdSetCoarseSampleOrderNV;
                commandDelegate(extendedHandle.handle, sampleOrderType, (uint)(Interop.HeapUtil.GetLength(customSampleOrders)), marshalledCustomSampleOrders);
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
        public static unsafe void BuildAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.AccelerationStructureInfo info, SharpVk.Buffer instanceData, DeviceSize instanceOffset, bool update, SharpVk.NVidia.AccelerationStructure destination, SharpVk.NVidia.AccelerationStructure source, SharpVk.Buffer scratch, DeviceSize scratchOffset)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.NVidia.AccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkCommandBufferBuildAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, instanceData?.handle ?? default(SharpVk.Interop.Buffer), instanceOffset, update, destination?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), source?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), scratch?.handle ?? default(SharpVk.Interop.Buffer), scratchOffset);
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
        public static unsafe void CopyAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.AccelerationStructure destination, SharpVk.NVidia.AccelerationStructure source, SharpVk.NVidia.CopyAccelerationStructureMode mode)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureNV;
                commandDelegate(extendedHandle.handle, destination?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), source?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure), mode);
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
        public static unsafe void TraceRays(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer raygenShaderBindingTableBuffer, DeviceSize raygenShaderBindingOffset, SharpVk.Buffer missShaderBindingTableBuffer, DeviceSize missShaderBindingOffset, DeviceSize missShaderBindingStride, SharpVk.Buffer hitShaderBindingTableBuffer, DeviceSize hitShaderBindingOffset, DeviceSize hitShaderBindingStride, SharpVk.Buffer callableShaderBindingTableBuffer, DeviceSize callableShaderBindingOffset, DeviceSize callableShaderBindingStride, uint width, uint height, uint depth)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferTraceRaysDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysNV;
                commandDelegate(extendedHandle.handle, raygenShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), raygenShaderBindingOffset, missShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer?.handle ?? default(SharpVk.Interop.Buffer), callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
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
        /// <param name="accelerationStructures">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.NVidia.AccelerationStructure>? accelerationStructures, SharpVk.QueryType queryType, SharpVk.QueryPool queryPool, uint firstQuery)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructure* marshalledAccelerationStructures = default(SharpVk.Interop.NVidia.AccelerationStructure*);
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (SharpVk.Interop.NVidia.AccelerationStructure*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructure>());
                        *(SharpVk.Interop.NVidia.AccelerationStructure*)(marshalledAccelerationStructures) = accelerationStructures.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.AccelerationStructure*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.AccelerationStructure>(Interop.HeapUtil.GetLength(accelerationStructures.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(accelerationStructures.Value)); index++)
                        {
                            fieldPointer[index] = accelerationStructures.Value[index]?.handle ?? default(SharpVk.Interop.NVidia.AccelerationStructure);
                        }
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkCmdWriteAccelerationStructuresPropertiesNV;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery);
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
        public static unsafe void DrawMeshTasks(this SharpVk.CommandBuffer extendedHandle, uint taskCount, uint firstTask)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksNV;
                commandDelegate(extendedHandle.handle, taskCount, firstTask);
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
        public static unsafe void DrawMeshTasksIndirect(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, uint drawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectNV;
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, drawCount, stride);
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
        public static unsafe void DrawMeshTasksIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferDrawMeshTasksIndirectCountDelegate commandDelegate = commandCache.Cache.vkCmdDrawMeshTasksIndirectCountNV;
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
        /// <param name="exclusiveScissors">
        /// </param>
        public static unsafe void SetExclusiveScissor(this SharpVk.CommandBuffer extendedHandle, uint firstExclusiveScissor, ArrayProxy<SharpVk.Rect2D>? exclusiveScissors)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledExclusiveScissors = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (exclusiveScissors.IsNull())
                {
                    marshalledExclusiveScissors = null;
                }
                else
                {
                    if (exclusiveScissors.Value.Contents == ProxyContents.Single)
                    {
                        marshalledExclusiveScissors = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>());
                        *(SharpVk.Rect2D*)(marshalledExclusiveScissors) = exclusiveScissors.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(Interop.HeapUtil.GetLength(exclusiveScissors.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(exclusiveScissors.Value)); index++)
                        {
                            fieldPointer[index] = exclusiveScissors.Value[index];
                        }
                        marshalledExclusiveScissors = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkCommandBufferSetExclusiveScissorDelegate commandDelegate = commandCache.Cache.vkCmdSetExclusiveScissorNV;
                commandDelegate(extendedHandle.handle, firstExclusiveScissor, (uint)(Interop.HeapUtil.GetLength(exclusiveScissors)), marshalledExclusiveScissors);
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
        public static unsafe void SetCheckpoint(this SharpVk.CommandBuffer extendedHandle, IntPtr checkpointMarker)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkCommandBufferSetCheckpointDelegate commandDelegate = commandCache.Cache.vkCmdSetCheckpointNV;
                commandDelegate(extendedHandle.handle, checkpointMarker.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
