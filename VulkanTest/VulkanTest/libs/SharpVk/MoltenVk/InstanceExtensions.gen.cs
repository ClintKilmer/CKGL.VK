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

namespace SharpVk.MoltenVk
{
    /// <summary>
    /// 
    /// </summary>
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a SurfaceKHR object for an iOS UIView.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="view">
        /// A reference to a UIView object which will display this surface.
        /// This UIView must be backed by a CALayer instance of type
        /// CAMetalLayer.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateIOSSurface(this SharpVk.Instance extendedHandle, IntPtr view, SharpVk.MoltenVk.IOSSurfaceCreateFlags? flags = default(SharpVk.MoltenVk.IOSSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.MoltenVk.IOSSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.MoltenVk.IOSSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.MoltenVk.IOSSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MoltenVk.IOSSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.IosSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.MoltenVk.IOSSurfaceCreateFlags);
                }
                marshalledCreateInfo->View = view.ToPointer();
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.MoltenVk.VkInstanceCreateIOSSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateIOSSurfaceMVK;
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
        /// Create a SurfaceKHR object for a macOS NSView.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="view">
        /// A reference to a NSView object which will display this surface.
        /// This NSView must be backed by a CALayer instance of type
        /// CAMetalLayer.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Surface CreateMacOSSurface(this SharpVk.Instance extendedHandle, IntPtr view, SharpVk.MoltenVk.MacOSSurfaceCreateFlags? flags = default(SharpVk.MoltenVk.MacOSSurfaceCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Surface result = default(SharpVk.Khronos.Surface);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.MoltenVk.MacOSSurfaceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.MoltenVk.MacOSSurfaceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Surface marshalledSurface = default(SharpVk.Interop.Khronos.Surface);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.MoltenVk.MacOSSurfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MoltenVk.MacOSSurfaceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.MacosSurfaceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.MoltenVk.MacOSSurfaceCreateFlags);
                }
                marshalledCreateInfo->View = view.ToPointer();
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.MoltenVk.VkInstanceCreateMacOSSurfaceDelegate commandDelegate = commandCache.Cache.vkCreateMacOSSurfaceMVK;
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
