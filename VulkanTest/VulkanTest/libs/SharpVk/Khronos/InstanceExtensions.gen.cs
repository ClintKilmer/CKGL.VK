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
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a SurfaceKHR structure representing a display plane and
        /// mode.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="displayMode">
        /// The mode to use when displaying this surface.
        /// </param>
        /// <param name="planeIndex">
        /// The plane on which this surface appears.
        /// </param>
        /// <param name="planeStackIndex">
        /// The z-order of the plane.
        /// </param>
        /// <param name="transform">
        /// The transform to apply to the images as part of the scanout
        /// operation.
        /// </param>
        /// <param name="globalAlpha">
        /// The global alpha value. This value is ignored if alphaMode is not
        /// VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </param>
        /// <param name="alphaMode">
        /// The type of alpha blending to use.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateDisplayPlaneSurface(this SharpVk.Instance extendedHandle, SharpVk.Khronos.DisplayMode displayMode, uint planeIndex, uint planeStackIndex, SharpVk.Khronos.SurfaceTransformFlags transform, float globalAlpha, SharpVk.Khronos.DisplayPlaneAlphaFlags alphaMode, SharpVk.Extent2D imageExtent, SharpVk.Khronos.DisplaySurfaceCreateFlags? flags = default(SharpVk.Khronos.DisplaySurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplaySurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DisplaySurfaceCreateFlags);
                }
                marshalledCreateInfo->DisplayMode = displayMode?.handle ?? default(SharpVk.Interop.Khronos.DisplayMode);
                marshalledCreateInfo->PlaneIndex = planeIndex;
                marshalledCreateInfo->PlaneStackIndex = planeStackIndex;
                marshalledCreateInfo->Transform = transform;
                marshalledCreateInfo->GlobalAlpha = globalAlpha;
                marshalledCreateInfo->AlphaMode = alphaMode;
                marshalledCreateInfo->ImageExtent = imageExtent;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateDisplayPlaneSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateDisplayPlaneSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an X11 window, using the Xlib
        /// client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="dpy">
        /// An Xlib Display connection to the X server.
        /// </param>
        /// <param name="window">
        /// An Xlib Window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateXlibSurface(this SharpVk.Instance extendedHandle, IntPtr dpy, IntPtr window, SharpVk.Khronos.XlibSurfaceCreateFlags? flags = default(SharpVk.Khronos.XlibSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.XlibSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.XlibSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.XlibSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.XlibSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.XlibSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.XlibSurfaceCreateFlags);
                }
                marshalledCreateInfo->Dpy = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Dpy = dpy;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateXlibSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateXlibSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for a X11 window, using the XCB
        /// client-side library.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="connection">
        /// An xcb_connection_t to the X server.
        /// </param>
        /// <param name="window">
        /// The xcb_window_t for the X11 window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateXcbSurface(this SharpVk.Instance extendedHandle, IntPtr connection, IntPtr window, SharpVk.Khronos.XcbSurfaceCreateFlags? flags = default(SharpVk.Khronos.XcbSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.XcbSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.XcbSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.XcbSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.XcbSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.XcbSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.XcbSurfaceCreateFlags);
                }
                marshalledCreateInfo->Connection = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Connection = connection;
                marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateXcbSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateXcbSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for a Wayland window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="display">
        /// display and surface are pointers to the Wayland wl_display and
        /// wl_surface to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateWaylandSurface(this SharpVk.Instance extendedHandle, IntPtr display, IntPtr surface, SharpVk.Khronos.WaylandSurfaceCreateFlags? flags = default(SharpVk.Khronos.WaylandSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.WaylandSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.WaylandSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.WaylandSurfaceCreateFlags);
                }
                marshalledCreateInfo->Display = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Display = display;
                marshalledCreateInfo->Surface = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Surface = surface;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateWaylandSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateWaylandSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an Android native window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="window">
        /// A pointer to the ANativeWindow to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateAndroidSurface(this SharpVk.Instance extendedHandle, IntPtr window, SharpVk.Khronos.AndroidSurfaceCreateFlags? flags = default(SharpVk.Khronos.AndroidSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AndroidSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AndroidSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.AndroidSurfaceCreateFlags);
                }
                marshalledCreateInfo->Window = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledCreateInfo->Window = window;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateAndroidSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateAndroidSurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a SurfaceKHR object for an Win32 native window.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="hinstance">
        /// Win32 HINSTANCE for the window to associate the surface with.
        /// </param>
        /// <param name="hwnd">
        /// Win32 HWND for the window to associate the surface with.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateWin32Surface(this SharpVk.Instance extendedHandle, IntPtr hinstance, IntPtr hwnd, SharpVk.Khronos.Win32SurfaceCreateFlags? flags = default(SharpVk.Khronos.Win32SurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.Win32SurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.Win32SurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.Win32SurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Win32SurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.Win32SurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.Win32SurfaceCreateFlags);
                }
                marshalledCreateInfo->Hinstance = hinstance;
                marshalledCreateInfo->Hwnd = hwnd;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkInstanceCreateWin32SurfaceDelegate commandDelegate = commandCache.Cache.vkCreateWin32SurfaceKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSurface);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Surface(extendedHandle, marshalledSurface);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
