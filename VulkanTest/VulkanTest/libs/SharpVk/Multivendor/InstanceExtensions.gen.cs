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
    public static class InstanceExtensions
    {
        /// <summary>
        /// Create a debug report callback object.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Instance handle to extend.
        /// </param>
        /// <param name="flags">
        /// flags indicate which event(s) will cause this callback to be
        /// called. Flags are interpreted as bitmasks and multiple may be set.
        /// Bits which can be set include: + --
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Multivendor.DebugReportCallback CreateDebugReportCallback(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugReportCallbackDelegate callback, SharpVk.Multivendor.DebugReportFlags? flags = default(SharpVk.Multivendor.DebugReportFlags?), IntPtr? userData = default(IntPtr?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.DebugReportCallback result = default(SharpVk.Multivendor.DebugReportCallback);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.DebugReportCallback marshalledCallback = default(SharpVk.Interop.Multivendor.DebugReportCallback);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DebugReportCallbackCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.DebugReportFlags);
                }
                marshalledCreateInfo->Callback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(callback);
                if (userData != null)
                {
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                }
                else
                {
                    marshalledCreateInfo->UserData = default(void*);
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
                SharpVk.Interop.Multivendor.VkInstanceCreateDebugReportCallbackDelegate commandDelegate = commandCache.Cache.vkCreateDebugReportCallbackEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCallback);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.DebugReportCallback(extendedHandle, marshalledCallback);
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
        /// The Instance handle to extend.
        /// </param>
        public static unsafe void DebugReportMessage(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugReportFlags flags, SharpVk.Multivendor.DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, string layerPrefix, string message)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkInstanceDebugReportMessageDelegate commandDelegate = commandCache.Cache.vkDebugReportMessageEXT;
                commandDelegate(extendedHandle.handle, flags, objectType, @object, location, messageCode, Interop.HeapUtil.MarshalTo(layerPrefix), Interop.HeapUtil.MarshalTo(message));
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
        /// The Instance handle to extend.
        /// </param>
        public static unsafe SharpVk.Multivendor.DebugUtilsMessenger CreateDebugUtilsMessenger(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugUtilsMessageSeverityFlags messageSeverity, SharpVk.Multivendor.DebugUtilsMessageTypeFlags messageType, SharpVk.Multivendor.DebugUtilsMessengerCallbackDelegate userCallback, SharpVk.Multivendor.DebugUtilsMessengerCreateFlags? flags = default(SharpVk.Multivendor.DebugUtilsMessengerCreateFlags?), IntPtr? userData = default(IntPtr?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Multivendor.DebugUtilsMessenger result = default(SharpVk.Multivendor.DebugUtilsMessenger);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Multivendor.DebugUtilsMessenger marshalledMessenger = default(SharpVk.Interop.Multivendor.DebugUtilsMessenger);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DebugUtilsMessengerCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Multivendor.DebugUtilsMessengerCreateFlags);
                }
                marshalledCreateInfo->MessageSeverity = messageSeverity;
                marshalledCreateInfo->MessageType = messageType;
                marshalledCreateInfo->UserCallback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(userCallback);
                if (userData != null)
                {
                    marshalledCreateInfo->UserData = userData.Value.ToPointer();
                }
                else
                {
                    marshalledCreateInfo->UserData = default(void*);
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
                SharpVk.Interop.Multivendor.VkInstanceCreateDebugUtilsMessengerDelegate commandDelegate = commandCache.Cache.vkCreateDebugUtilsMessengerEXT;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledMessenger);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Multivendor.DebugUtilsMessenger(extendedHandle, marshalledMessenger);
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
        /// The Instance handle to extend.
        /// </param>
        public static unsafe void SubmitDebugUtilsMessage(this SharpVk.Instance extendedHandle, SharpVk.Multivendor.DebugUtilsMessageSeverityFlags messageSeverity, SharpVk.Multivendor.DebugUtilsMessageTypeFlags messageTypes, SharpVk.Multivendor.DebugUtilsMessengerCallbackData callbackData)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData* marshalledCallbackData = default(SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData*);
                commandCache = extendedHandle.commandCache;
                marshalledCallbackData = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData>());
                callbackData.MarshalTo(marshalledCallbackData);
                SharpVk.Interop.Multivendor.VkInstanceSubmitDebugUtilsMessageDelegate commandDelegate = commandCache.Cache.vkSubmitDebugUtilsMessageEXT;
                commandDelegate(extendedHandle.handle, messageSeverity, messageTypes, marshalledCallbackData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
