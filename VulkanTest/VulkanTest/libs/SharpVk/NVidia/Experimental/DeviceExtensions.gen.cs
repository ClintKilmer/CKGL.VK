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

namespace SharpVk.NVidia.Experimental
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
        /// <param name="pipelineBindPoint">
        /// The PipelineBindPoint that this layout targets.
        /// </param>
        /// <param name="flags">
        /// A bitmask providing usage hints of this layout. See
        /// IndirectCommandsLayoutUsageFlagBitsNVX below for a description of
        /// the supported bits.
        /// </param>
        /// <param name="tokens">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.IndirectCommandsLayout CreateIndirectCommandsLayout(this SharpVk.Device extendedHandle, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.NVidia.Experimental.IndirectCommandsLayoutUsageFlags flags, ArrayProxy<SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken>? tokens, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.IndirectCommandsLayout result = default(SharpVk.NVidia.Experimental.IndirectCommandsLayout);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout marshalledIndirectCommandsLayout = default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IndirectCommandsLayoutCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->Flags = flags;
                marshalledCreateInfo->TokenCount = (uint)(Interop.HeapUtil.GetLength(tokens));
                if (tokens.IsNull())
                {
                    marshalledCreateInfo->Tokens = null;
                }
                else
                {
                    if (tokens.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Tokens = (SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken>());
                        *(SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken*)(marshalledCreateInfo->Tokens) = tokens.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken>(Interop.HeapUtil.GetLength(tokens.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(tokens.Value)); index++)
                        {
                            fieldPointer[index] = tokens.Value[index];
                        }
                        marshalledCreateInfo->Tokens = fieldPointer;
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
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateIndirectCommandsLayoutDelegate commandDelegate = commandCache.Cache.vkCreateIndirectCommandsLayoutNVX;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledIndirectCommandsLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.IndirectCommandsLayout(extendedHandle, marshalledIndirectCommandsLayout);
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
        /// <param name="objectEntryTypes">
        /// </param>
        /// <param name="objectEntryCounts">
        /// </param>
        /// <param name="objectEntryUsageFlags">
        /// </param>
        /// <param name="maxUniformBuffersPerDescriptor">
        /// The maximum number of DescriptorType.UniformBuffer or
        /// DescriptorType.UniformBufferDynamic used by any single registered
        /// DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageBuffersPerDescriptor">
        /// The maximum number of DescriptorType.StorageBuffer or
        /// DescriptorType.StorageBufferDynamic used by any single registered
        /// DescriptorSet in this table.
        /// </param>
        /// <param name="maxStorageImagesPerDescriptor">
        /// The maximum number of DescriptorType.StorageImage or
        /// DescriptorType.StorageTexelBuffer used by any single registered
        /// DescriptorSet in this table.
        /// </param>
        /// <param name="maxSampledImagesPerDescriptor">
        /// The maximum number of DescriptorType.Sampler,
        /// DescriptorType.CombinedImageSampler, DescriptorType.UniformTexelBuffer
        /// or DescriptorType.InputAttachment used by any single registered
        /// DescriptorSet in this table.
        /// </param>
        /// <param name="maxPipelineLayouts">
        /// The maximum number of unique PipelineLayout used by any registered
        /// DescriptorSet or Pipeline in this table.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.ObjectTable CreateObjectTable(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.NVidia.Experimental.ObjectEntryType>? objectEntryTypes, ArrayProxy<uint>? objectEntryCounts, ArrayProxy<SharpVk.NVidia.Experimental.ObjectEntryUsageFlags>? objectEntryUsageFlags, uint maxUniformBuffersPerDescriptor, uint maxStorageBuffersPerDescriptor, uint maxStorageImagesPerDescriptor, uint maxSampledImagesPerDescriptor, uint maxPipelineLayouts, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectTable result = default(SharpVk.NVidia.Experimental.ObjectTable);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.NVidia.Experimental.ObjectTable marshalledObjectTable = default(SharpVk.Interop.NVidia.Experimental.ObjectTable);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.ObjectTableCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ObjectTableCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                marshalledCreateInfo->ObjectCount = (uint)(Interop.HeapUtil.GetLength(objectEntryTypes));
                if (objectEntryTypes.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryTypes = null;
                }
                else
                {
                    if (objectEntryTypes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryTypes = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.Experimental.ObjectEntryType>());
                        *(SharpVk.NVidia.Experimental.ObjectEntryType*)(marshalledCreateInfo->ObjectEntryTypes) = objectEntryTypes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryType>(Interop.HeapUtil.GetLength(objectEntryTypes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectEntryTypes.Value)); index++)
                        {
                            fieldPointer[index] = objectEntryTypes.Value[index];
                        }
                        marshalledCreateInfo->ObjectEntryTypes = fieldPointer;
                    }
                }
                if (objectEntryCounts.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryCounts = null;
                }
                else
                {
                    if (objectEntryCounts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryCounts = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->ObjectEntryCounts) = objectEntryCounts.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(objectEntryCounts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectEntryCounts.Value)); index++)
                        {
                            fieldPointer[index] = objectEntryCounts.Value[index];
                        }
                        marshalledCreateInfo->ObjectEntryCounts = fieldPointer;
                    }
                }
                if (objectEntryUsageFlags.IsNull())
                {
                    marshalledCreateInfo->ObjectEntryUsageFlags = null;
                }
                else
                {
                    if (objectEntryUsageFlags.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->ObjectEntryUsageFlags = (SharpVk.NVidia.Experimental.ObjectEntryUsageFlags*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.Experimental.ObjectEntryUsageFlags>());
                        *(SharpVk.NVidia.Experimental.ObjectEntryUsageFlags*)(marshalledCreateInfo->ObjectEntryUsageFlags) = objectEntryUsageFlags.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryUsageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryUsageFlags>(Interop.HeapUtil.GetLength(objectEntryUsageFlags.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectEntryUsageFlags.Value)); index++)
                        {
                            fieldPointer[index] = objectEntryUsageFlags.Value[index];
                        }
                        marshalledCreateInfo->ObjectEntryUsageFlags = fieldPointer;
                    }
                }
                marshalledCreateInfo->MaxUniformBuffersPerDescriptor = maxUniformBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageBuffersPerDescriptor = maxStorageBuffersPerDescriptor;
                marshalledCreateInfo->MaxStorageImagesPerDescriptor = maxStorageImagesPerDescriptor;
                marshalledCreateInfo->MaxSampledImagesPerDescriptor = maxSampledImagesPerDescriptor;
                marshalledCreateInfo->MaxPipelineLayouts = maxPipelineLayouts;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.NVidia.Experimental.VkDeviceCreateObjectTableDelegate commandDelegate = commandCache.Cache.vkCreateObjectTableNVX;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledObjectTable);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.NVidia.Experimental.ObjectTable(extendedHandle, marshalledObjectTable);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
