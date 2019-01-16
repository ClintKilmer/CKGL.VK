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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Query if presentation is supported.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe bool GetSurfaceSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, SharpVk.Khronos.Surface surface)
        {
            try
            {
                bool result = default(bool);
                CommandCache commandCache = default(CommandCache);
                Bool32 marshalledSupported = default(Bool32);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceSupportKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledSupported);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledSupported;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query surface capabilities.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceCapabilities GetSurfaceCapabilities(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.SurfaceCapabilities result = default(SharpVk.Khronos.SurfaceCapabilities);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.SurfaceCapabilities marshalledSurfaceCapabilities = default(SharpVk.Khronos.SurfaceCapabilities);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledSurfaceCapabilities;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query color formats supported by surface.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceFormat[] GetSurfaceFormats(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.SurfaceFormat[] result = default(SharpVk.Khronos.SurfaceFormat[]);
                uint surfaceFormatCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.SurfaceFormat* marshalledSurfaceFormats = default(SharpVk.Khronos.SurfaceFormat*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormatsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormatsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &surfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SharpVk.Khronos.SurfaceFormat*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.SurfaceFormat>((uint)(surfaceFormatCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &surfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SurfaceFormat[(uint)(surfaceFormatCount)];
                    for(int index = 0; index < (uint)(surfaceFormatCount); index++)
                    {
                        fieldPointer[index] = marshalledSurfaceFormats[index];
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
        /// Query supported presentation modes.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.PresentMode[] GetSurfacePresentModes(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.PresentMode[] result = default(SharpVk.Khronos.PresentMode[]);
                uint presentModeCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.PresentMode* marshalledPresentModes = default(SharpVk.Khronos.PresentMode*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfacePresentModesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfacePresentModesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &presentModeCount, marshalledPresentModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledPresentModes = (SharpVk.Khronos.PresentMode*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.PresentMode>((uint)(presentModeCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &presentModeCount, marshalledPresentModes);
                if (marshalledPresentModes != null)
                {
                    var fieldPointer = new SharpVk.Khronos.PresentMode[(uint)(presentModeCount)];
                    for(int index = 0; index < (uint)(presentModeCount); index++)
                    {
                        fieldPointer[index] = marshalledPresentModes[index];
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Rect2D[] GetPresentRectangles(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Rect2D[] result = default(SharpVk.Rect2D[]);
                uint rectCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledRects = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetPresentRectanglesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDevicePresentRectanglesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &rectCount, marshalledRects);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledRects = (SharpVk.Rect2D*)(Interop.HeapUtil.Allocate<SharpVk.Rect2D>((uint)(rectCount)));
                commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &rectCount, marshalledRects);
                if (marshalledRects != null)
                {
                    var fieldPointer = new SharpVk.Rect2D[(uint)(rectCount)];
                    for(int index = 0; index < (uint)(rectCount); index++)
                    {
                        fieldPointer[index] = marshalledRects[index];
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
        /// Query information about the available displays.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayProperties[] GetDisplayProperties(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayProperties[] result = default(SharpVk.Khronos.DisplayProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// Query the plane properties.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayPlaneProperties[] GetDisplayPlaneProperties(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayPlaneProperties[] result = default(SharpVk.Khronos.DisplayPlaneProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayPlaneProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayPlaneProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlanePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayPlaneProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayPlaneProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayPlaneProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// Query the list of displays a plane supports.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.Display[] GetDisplayPlaneSupportedDisplays(this SharpVk.PhysicalDevice extendedHandle, uint planeIndex)
        {
            try
            {
                SharpVk.Khronos.Display[] result = default(SharpVk.Khronos.Display[]);
                uint displayCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Display* marshalledDisplays = default(SharpVk.Interop.Khronos.Display*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneSupportedDisplaysDelegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneSupportedDisplaysKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, planeIndex, &displayCount, marshalledDisplays);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledDisplays = (SharpVk.Interop.Khronos.Display*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Display>((uint)(displayCount)));
                commandDelegate(extendedHandle.handle, planeIndex, &displayCount, marshalledDisplays);
                if (marshalledDisplays != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Display[(uint)(displayCount)];
                    for(int index = 0; index < (uint)(displayCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Display(marshalledDisplays[index]);
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
        /// Query the set of mode properties supported by the display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayModeProperties[] GetDisplayModeProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display)
        {
            try
            {
                SharpVk.Khronos.DisplayModeProperties[] result = default(SharpVk.Khronos.DisplayModeProperties[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayModeProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayModeProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayModePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDisplayModePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayModeProperties[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// Create a display mode.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="parameters">
        /// A DisplayModeParametersKHR structure describing the display
        /// parameters to use in creating the new mode. If the parameters are
        /// not compatible with the specified display, the implementation must
        /// return Result.ErrorINITIALIZATION_FAILED.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayMode CreateDisplayMode(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display, SharpVk.Khronos.DisplayModeParameters parameters, SharpVk.Khronos.DisplayModeCreateFlags? flags = default(SharpVk.Khronos.DisplayModeCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DisplayMode result = default(SharpVk.Khronos.DisplayMode);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayModeCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DisplayModeCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DisplayMode marshalledMode = default(SharpVk.Interop.Khronos.DisplayMode);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplayModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplayModeCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DisplayModeCreateFlags);
                }
                marshalledCreateInfo->Parameters = parameters;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkPhysicalDeviceCreateDisplayModeDelegate commandDelegate = commandCache.Cache.vkCreateDisplayModeKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), marshalledCreateInfo, marshalledAllocator, &marshalledMode);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DisplayMode(extendedHandle, marshalledMode);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to X11 server using Xlib.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetXlibPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr dpy, IntPtr visualID)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledDpy = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDpy = dpy;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXlibPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXlibPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledDpy, visualID);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to X11 server using XCB.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetXcbPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr connection, IntPtr visualId)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledConnection = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledConnection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledConnection = connection;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetXcbPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceXcbPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledConnection, visualId);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query physical device for presentation to Wayland.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetWaylandPresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, IntPtr display)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledDisplay = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledDisplay = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledDisplay = display;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWaylandPresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWaylandPresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledDisplay);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Query queue family support for presentation on a Win32 display.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe void GetWin32PresentationSupport(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetWin32PresentationSupportDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceWin32PresentationSupportKHR;
                commandDelegate(extendedHandle.handle, queueFamilyIndex);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceCapabilities2 GetSurfaceCapabilities2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SharpVk.Khronos.SurfaceCapabilities2 result = default(SharpVk.Khronos.SurfaceCapabilities2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                SharpVk.Interop.Khronos.SurfaceCapabilities2 marshalledSurfaceCapabilities = default(SharpVk.Interop.Khronos.SurfaceCapabilities2);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceCapabilities2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceCapabilities2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &marshalledSurfaceCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.SurfaceCapabilities2.MarshalFrom(&marshalledSurfaceCapabilities);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.SurfaceFormat2[] GetSurfaceFormats2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.PhysicalDeviceSurfaceInfo2 surfaceInfo)
        {
            try
            {
                SharpVk.Khronos.SurfaceFormat2[] result = default(SharpVk.Khronos.SurfaceFormat2[]);
                uint surfaceFormatCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2* marshalledSurfaceInfo = default(SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*);
                SharpVk.Interop.Khronos.SurfaceFormat2* marshalledSurfaceFormats = default(SharpVk.Interop.Khronos.SurfaceFormat2*);
                commandCache = extendedHandle.commandCache;
                marshalledSurfaceInfo = (SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceSurfaceInfo2>());
                surfaceInfo.MarshalTo(marshalledSurfaceInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetSurfaceFormats2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSurfaceFormats2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &surfaceFormatCount, marshalledSurfaceFormats);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSurfaceFormats = (SharpVk.Interop.Khronos.SurfaceFormat2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SurfaceFormat2>((uint)(surfaceFormatCount)));
                commandDelegate(extendedHandle.handle, marshalledSurfaceInfo, &surfaceFormatCount, marshalledSurfaceFormats);
                if (marshalledSurfaceFormats != null)
                {
                    var fieldPointer = new SharpVk.Khronos.SurfaceFormat2[(uint)(surfaceFormatCount)];
                    for(int index = 0; index < (uint)(surfaceFormatCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.SurfaceFormat2.MarshalFrom(&marshalledSurfaceFormats[index]);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayProperties2[] GetDisplayProperties2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayProperties2[] result = default(SharpVk.Khronos.DisplayProperties2[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayProperties2* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayProperties2*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayProperties2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayProperties2>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayProperties2[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayProperties2.MarshalFrom(&marshalledProperties[index]);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayPlaneProperties2[] GetDisplayPlaneProperties2(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DisplayPlaneProperties2[] result = default(SharpVk.Khronos.DisplayPlaneProperties2[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayPlaneProperties2* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayPlaneProperties2*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayPlaneProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneProperties2>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayPlaneProperties2[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayPlaneProperties2.MarshalFrom(&marshalledProperties[index]);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayModeProperties2[] GetDisplayModeProperties2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.Display display)
        {
            try
            {
                SharpVk.Khronos.DisplayModeProperties2[] result = default(SharpVk.Khronos.DisplayModeProperties2[]);
                uint propertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayModeProperties2* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayModeProperties2*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayModeProperties2Delegate commandDelegate = commandCache.Cache.vkGetDisplayModeProperties2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties2>((uint)(propertyCount)));
                commandDelegate(extendedHandle.handle, display?.handle ?? default(SharpVk.Interop.Khronos.Display), &propertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayModeProperties2[(uint)(propertyCount)];
                    for(int index = 0; index < (uint)(propertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayModeProperties2.MarshalFrom(&marshalledProperties[index]);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Khronos.DisplayPlaneCapabilities2 GetDisplayPlaneCapabilities2(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Khronos.DisplayPlaneInfo2 displayPlaneInfo)
        {
            try
            {
                SharpVk.Khronos.DisplayPlaneCapabilities2 result = default(SharpVk.Khronos.DisplayPlaneCapabilities2);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplayPlaneInfo2* marshalledDisplayPlaneInfo = default(SharpVk.Interop.Khronos.DisplayPlaneInfo2*);
                SharpVk.Interop.Khronos.DisplayPlaneCapabilities2 marshalledCapabilities = default(SharpVk.Interop.Khronos.DisplayPlaneCapabilities2);
                commandCache = extendedHandle.commandCache;
                marshalledDisplayPlaneInfo = (SharpVk.Interop.Khronos.DisplayPlaneInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPlaneInfo2>());
                displayPlaneInfo.MarshalTo(marshalledDisplayPlaneInfo);
                SharpVk.Interop.Khronos.VkPhysicalDeviceGetDisplayPlaneCapabilities2Delegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneCapabilities2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledDisplayPlaneInfo, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.DisplayPlaneCapabilities2.MarshalFrom(&marshalledCapabilities);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
