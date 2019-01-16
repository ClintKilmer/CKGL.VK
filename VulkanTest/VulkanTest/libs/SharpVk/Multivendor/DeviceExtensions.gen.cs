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
    public static class DeviceExtensions
    {
        /// <summary>
        /// Set the power state of a display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe void DisplayPowerControl(this SharpVk.Device extendedHandle, SharpVk.Khronos.Display display, SharpVk.Multivendor.DisplayPowerInfo displayPowerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DisplayPowerInfo* marshalledDisplayPowerInfo = default(SharpVk.Interop.Multivendor.DisplayPowerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPowerInfo = (SharpVk.Interop.Multivendor.DisplayPowerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayPowerInfo>());
                displayPowerInfo.MarshalTo(marshalledDisplayPowerInfo);
                SharpVk.Interop.Multivendor.VkDeviceDisplayPowerControlDelegate commandDelegate = commandCache.Cache.vkDisplayPowerControlEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledDisplayPowerInfo);
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
        /// Signal a fence when a device event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Fence RegisterEvent(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DeviceEventInfo deviceEventInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DeviceEventInfo* marshalledDeviceEventInfo = default(SharpVk.Interop.Multivendor.DeviceEventInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                commandCache = extendedHandle.commandCache;
                marshalledDeviceEventInfo = (SharpVk.Interop.Multivendor.DeviceEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DeviceEventInfo>());
                deviceEventInfo.MarshalTo(marshalledDeviceEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterEventDelegate commandDelegate = commandCache.Cache.vkRegisterDeviceEventEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledDeviceEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(extendedHandle, marshalledFence);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Signal a fence when a display event occurs.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Fence RegisterDisplayEvent(this SharpVk.Device extendedHandle, SharpVk.Khronos.Display display, SharpVk.Multivendor.DisplayEventInfo displayEventInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DisplayEventInfo* marshalledDisplayEventInfo = default(SharpVk.Interop.Multivendor.DisplayEventInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayEventInfo = (SharpVk.Interop.Multivendor.DisplayEventInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DisplayEventInfo>());
                displayEventInfo.MarshalTo(marshalledDisplayEventInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Multivendor.VkDeviceRegisterDisplayEventDelegate commandDelegate = commandCache.Cache.vkRegisterDisplayEventEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledDisplayEventInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(extendedHandle, marshalledFence);
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
        /// <param name="swapchains">
        /// </param>
        /// <param name="metadata">
        /// </param>
        public static unsafe void SetHdrMetadata(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.Swapchain>? swapchains, ArrayProxy<SharpVk.Multivendor.HdrMetadata>? metadata)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                SharpVk.Interop.Multivendor.HdrMetadata* marshalledMetadata = default(SharpVk.Interop.Multivendor.HdrMetadata*);
                commandCache = extendedHandle.commandCache;
                if (swapchains.IsNull())
                {
                    marshalledSwapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>());
                        *(SharpVk.Interop.Khronos.Swapchain*)(marshalledSwapchains) = swapchains.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(Interop.HeapUtil.GetLength(swapchains.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(swapchains.Value)); index++)
                        {
                            fieldPointer[index] = swapchains.Value[index]?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                        }
                        marshalledSwapchains = fieldPointer;
                    }
                }
                if (metadata.IsNull())
                {
                    marshalledMetadata = null;
                }
                else
                {
                    if (metadata.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMetadata = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.HdrMetadata>());
                        metadata.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.HdrMetadata*)(marshalledMetadata));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.HdrMetadata*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.HdrMetadata>(Interop.HeapUtil.GetLength(metadata.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(metadata.Value)); index++)
                        {
                            metadata.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMetadata = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceSetHdrMetadataDelegate commandDelegate = commandCache.Cache.vkSetHdrMetadataEXT;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(swapchains)), marshalledSwapchains, marshalledMetadata);
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
        public static unsafe void SetDebugUtilsObjectName(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DebugUtilsObjectNameInfo nameInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo* marshalledNameInfo = default(SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledNameInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo>());
                nameInfo.MarshalTo(marshalledNameInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectNameDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectNameEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledNameInfo);
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
        public static unsafe void SetDebugUtilsObjectTag(this SharpVk.Device extendedHandle, SharpVk.Multivendor.DebugUtilsObjectTagInfo tagInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo* marshalledTagInfo = default(SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledTagInfo = (SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsObjectTagInfo>());
                tagInfo.MarshalTo(marshalledTagInfo);
                SharpVk.Interop.Multivendor.VkDeviceSetDebugUtilsObjectTagDelegate commandDelegate = commandCache.Cache.vkSetDebugUtilsObjectTagEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledTagInfo);
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
        /// <param name="initialData">
        /// </param>
        public static unsafe SharpVk.Multivendor.ValidationCache CreateValidationCache(this SharpVk.Device extendedHandle, ArrayProxy<byte>? initialData, SharpVk.Multivendor.ValidationCacheCreateFlags? flags = default(SharpVk.Multivendor.ValidationCacheCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.ValidationCache result = default(SharpVk.Multivendor.ValidationCache);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.ValidationCacheCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.ValidationCacheCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.ValidationCache marshalledValidationCache = default(SharpVk.Interop.Multivendor.ValidationCache);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.ValidationCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ValidationCacheCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.ValidationCacheCreateFlags);
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(Interop.HeapUtil.GetLength(initialData));
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->InitialData) = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(initialData.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(initialData.Value)); index++)
                        {
                            fieldPointer[index] = initialData.Value[index];
                        }
                        marshalledCreateInfo->InitialData = fieldPointer;
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
                SharpVk.Interop.Multivendor.VkDeviceCreateValidationCacheDelegate commandDelegate = commandCache.Cache.vkCreateValidationCacheEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledValidationCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.ValidationCache(extendedHandle, marshalledValidationCache);
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
        public static unsafe SharpVk.Multivendor.MemoryHostPointerProperties GetMemoryHostPointerProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr hostPointer)
        {
            try
            {
                SharpVk.Multivendor.MemoryHostPointerProperties result = default(SharpVk.Multivendor.MemoryHostPointerProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.MemoryHostPointerProperties marshalledMemoryHostPointerProperties = default(SharpVk.Interop.Multivendor.MemoryHostPointerProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkDeviceGetMemoryHostPointerPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryHostPointerPropertiesEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, hostPointer.ToPointer(), &marshalledMemoryHostPointerProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Multivendor.MemoryHostPointerProperties.MarshalFrom(&marshalledMemoryHostPointerProperties);
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
        /// <param name="timestampInfos">
        /// </param>
        /// <param name="timestamps">
        /// </param>
        public static unsafe ulong GetCalibratedTimestamps(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Multivendor.CalibratedTimestampInfo>? timestampInfos, ArrayProxy<ulong>? timestamps)
        {
            try
            {
                ulong result = default(ulong);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.CalibratedTimestampInfo* marshalledTimestampInfos = default(SharpVk.Interop.Multivendor.CalibratedTimestampInfo*);
                ulong* marshalledTimestamps = default(ulong*);
                ulong marshalledMaxDeviation = default(ulong);
                commandCache = extendedHandle.commandCache;
                if (timestampInfos.IsNull())
                {
                    marshalledTimestampInfos = null;
                }
                else
                {
                    if (timestampInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestampInfos = (SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.CalibratedTimestampInfo>());
                        timestampInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(marshalledTimestampInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Multivendor.CalibratedTimestampInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.CalibratedTimestampInfo>(Interop.HeapUtil.GetLength(timestampInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(timestampInfos.Value)); index++)
                        {
                            timestampInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledTimestampInfos = fieldPointer;
                    }
                }
                if (timestamps.IsNull())
                {
                    marshalledTimestamps = null;
                }
                else
                {
                    if (timestamps.Value.Contents == ProxyContents.Single)
                    {
                        marshalledTimestamps = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledTimestamps) = timestamps.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(timestamps.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(timestamps.Value)); index++)
                        {
                            fieldPointer[index] = timestamps.Value[index];
                        }
                        marshalledTimestamps = fieldPointer;
                    }
                }
                SharpVk.Interop.Multivendor.VkDeviceGetCalibratedTimestampsDelegate commandDelegate = commandCache.Cache.vkGetCalibratedTimestampsEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(timestampInfos)), marshalledTimestampInfos, marshalledTimestamps, &marshalledMaxDeviation);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledMaxDeviation;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
