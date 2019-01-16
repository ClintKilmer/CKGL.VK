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
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.AccelerationStructure CreateAccelerationStructure(this SharpVk.Device extendedHandle, DeviceSize compactedSize, SharpVk.NVidia.AccelerationStructureInfo info, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.AccelerationStructure result = default(SharpVk.NVidia.AccelerationStructure);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.AccelerationStructureCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.AccelerationStructure marshalledAccelerationStructure = default(SharpVk.Interop.NVidia.AccelerationStructure);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.AccelerationStructureCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                marshalledCreateInfo->CompactedSize = compactedSize;
                info.MarshalTo(&marshalledCreateInfo->Info);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.VkDeviceCreateAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCreateAccelerationStructureNV;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.AccelerationStructure(extendedHandle, marshalledAccelerationStructure);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe SharpVk.MemoryRequirements2 GetAccelerationStructureMemoryRequirements(this SharpVk.Device extendedHandle, SharpVk.NVidia.AccelerationStructureMemoryRequirementsInfo info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo* marshalledInfo = default(SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureMemoryRequirementsInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.NVidia.VkDeviceGetAccelerationStructureMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureMemoryRequirementsNV;
                commandDelegate(extendedHandle.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="bindInfos">
        /// </param>
        public static unsafe void BindAccelerationStructureMemory(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.NVidia.BindAccelerationStructureMemoryInfo>? bindInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.BindAccelerationStructureMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.VkDeviceBindAccelerationStructureMemoryDelegate commandDelegate = commandCache.Cache.vkBindAccelerationStructureMemoryNV;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="createInfos">
        /// </param>
        public static unsafe SharpVk.Pipeline[] CreateRayTracingPipelines(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.NVidia.RayTracingPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                CommandCache commandCache = default(CommandCache);
                uint createInfoCount = default(uint);
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                commandCache = extendedHandle.commandCache;
                createInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(createInfoCount));
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(createInfoCount)];
                    for(int index = 0; index < (uint)(createInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(extendedHandle, marshalledPipelines[index]);
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
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        public static unsafe SharpVk.Pipeline CreateRayTracingPipeline(this SharpVk.Device extendedHandle, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.PipelineShaderStageCreateInfo>? stages, ArrayProxy<SharpVk.NVidia.RayTracingShaderGroupCreateInfo>? groups, uint maxRecursionDepth, SharpVk.PipelineLayout layout, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                CommandCache commandCache = default(CommandCache);
                uint createInfoCount = default(uint);
                SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                commandCache = extendedHandle.commandCache;
                createInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfo;
                marshalledCreateInfos->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags);
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                marshalledCreateInfos->GroupCount = (uint)(Interop.HeapUtil.GetLength(groups));
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>());
                        groups.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(marshalledCreateInfos->Groups));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>(Interop.HeapUtil.GetLength(groups.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(groups.Value)); index++)
                        {
                            groups.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxRecursionDepth = maxRecursionDepth;
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.NVidia.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Pipeline(extendedHandle, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
