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
    public static class DeviceExtensions
    {
        /// <summary>
        /// Create a swapchain.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain CreateSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, SharpVk.Khronos.DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, SharpVk.Khronos.ImageFormatListCreateInfo? imageFormatListCreateInfoKhr = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain marshalledSwapchain = default(SharpVk.Interop.Khronos.Swapchain);
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImageFormatListCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImageFormatListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfo->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
                marshalledCreateInfo->MinImageCount = minImageCount;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->ImageColorSpace = imageColorSpace;
                marshalledCreateInfo->ImageExtent = imageExtent;
                marshalledCreateInfo->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfo->ImageUsage = imageUsage;
                marshalledCreateInfo->ImageSharingMode = imageSharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->PreTransform = preTransform;
                marshalledCreateInfo->CompositeAlpha = compositeAlpha;
                marshalledCreateInfo->PresentMode = presentMode;
                marshalledCreateInfo->Clipped = clipped;
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.Cache.vkCreateSwapchainKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchain);
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
        public static unsafe SharpVk.Khronos.DeviceGroupPresentCapabilities GetGroupPresentCapabilities(this SharpVk.Device extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DeviceGroupPresentCapabilities result = default(SharpVk.Khronos.DeviceGroupPresentCapabilities);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DeviceGroupPresentCapabilities marshalledDeviceGroupPresentCapabilities = default(SharpVk.Interop.Khronos.DeviceGroupPresentCapabilities);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupPresentCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupPresentCapabilitiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledDeviceGroupPresentCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.DeviceGroupPresentCapabilities.MarshalFrom(&marshalledDeviceGroupPresentCapabilities);
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
        public static unsafe SharpVk.Khronos.DeviceGroupPresentModeFlags GetGroupSurfacePresentModes(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.DeviceGroupPresentModeFlags result = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.DeviceGroupPresentModeFlags marshalledModes = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupSurfacePresentModesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupSurfacePresentModesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledModes;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        public static unsafe uint AcquireNextImage2(this SharpVk.Device extendedHandle, SharpVk.Khronos.AcquireNextImageInfo acquireInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AcquireNextImageInfo* marshalledAcquireInfo = default(SharpVk.Interop.Khronos.AcquireNextImageInfo*);
                uint marshalledImageIndex = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (SharpVk.Interop.Khronos.AcquireNextImageInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AcquireNextImageInfo>());
                acquireInfo.MarshalTo(marshalledAcquireInfo);
                SharpVk.Interop.Khronos.VkDeviceAcquireNextImage2Delegate commandDelegate = commandCache.Cache.vkAcquireNextImage2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledAcquireInfo, &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageIndex;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain[] CreateSharedSwapchains(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.SwapchainCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain[] result = default(SharpVk.Khronos.Swapchain[]);
                CommandCache commandCache = default(CommandCache);
                uint swapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                commandCache = extendedHandle.commandCache;
                swapchainCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.SwapchainCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SwapchainCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
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
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(swapchainCount));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, swapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Swapchain[(uint)(swapchainCount)];
                    for(int index = 0; index < (uint)(swapchainCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchains[index]);
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
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain CreateSharedSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, SharpVk.Khronos.DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, SharpVk.Khronos.ImageFormatListCreateInfo? imageFormatListCreateInfoKhr = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                uint swapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImageFormatListCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImageFormatListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                swapchainCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfos->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfos->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfos->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
                marshalledCreateInfos->MinImageCount = minImageCount;
                marshalledCreateInfos->ImageFormat = imageFormat;
                marshalledCreateInfos->ImageColorSpace = imageColorSpace;
                marshalledCreateInfos->ImageExtent = imageExtent;
                marshalledCreateInfos->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfos->ImageUsage = imageUsage;
                marshalledCreateInfos->ImageSharingMode = imageSharingMode;
                marshalledCreateInfos->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfos->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfos->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfos->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfos->PreTransform = preTransform;
                marshalledCreateInfos->CompositeAlpha = compositeAlpha;
                marshalledCreateInfos->PresentMode = presentMode;
                marshalledCreateInfos->Clipped = clipped;
                marshalledCreateInfos->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(1));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, swapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, *marshalledSwapchains);
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
        public static unsafe IntPtr GetMemoryWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        public static unsafe SharpVk.Khronos.MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Khronos.MemoryWin32HandleProperties result = default(SharpVk.Khronos.MemoryWin32HandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default(SharpVk.Interop.Khronos.MemoryWin32HandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandlePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        public static unsafe int GetMemoryFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        public static unsafe SharpVk.Khronos.MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                SharpVk.Khronos.MemoryFileDescriptorProperties result = default(SharpVk.Khronos.MemoryFileDescriptorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default(SharpVk.Interop.Khronos.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        public static unsafe void ImportSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreWin32HandleInfo);
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
        public static unsafe IntPtr GetSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        public static unsafe void ImportSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreFileDescriptorInfo);
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
        public static unsafe int GetSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        public static unsafe SharpVk.RenderPass CreateRenderPass2(this SharpVk.Device extendedHandle, SharpVk.Khronos.RenderPassCreateInfo2 createInfo, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.RenderPass result = default(SharpVk.RenderPass);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.RenderPassCreateInfo2* marshalledCreateInfo = default(SharpVk.Interop.Khronos.RenderPassCreateInfo2*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.RenderPass marshalledRenderPass = default(SharpVk.Interop.RenderPass);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.RenderPassCreateInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RenderPassCreateInfo2>());
                createInfo.MarshalTo(marshalledCreateInfo);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateRenderPass2Delegate commandDelegate = commandCache.Cache.vkCreateRenderPass2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.RenderPass(extendedHandle, marshalledRenderPass);
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
        public static unsafe void ImportFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo* marshalledImportFenceWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceWin32HandleInfo = (SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo>());
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceWin32HandleInfo);
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
        public static unsafe IntPtr GetFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        public static unsafe void ImportFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo* marshalledImportFenceFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo>());
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceFileDescriptorInfo);
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
        public static unsafe int GetFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
