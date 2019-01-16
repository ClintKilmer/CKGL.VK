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

namespace SharpVk.Android
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
        public static unsafe SharpVk.Android.AndroidHardwareBufferProperties GetAndroidHardwareBufferProperties(this SharpVk.Device extendedHandle, IntPtr buffer)
        {
            try
            {
                SharpVk.Android.AndroidHardwareBufferProperties result = default(SharpVk.Android.AndroidHardwareBufferProperties);
                CommandCache commandCache = default(CommandCache);
                IntPtr* marshalledBuffer = default(IntPtr*);
                SharpVk.Interop.Android.AndroidHardwareBufferProperties marshalledProperties = default(SharpVk.Interop.Android.AndroidHardwareBufferProperties);
                commandCache = extendedHandle.commandCache;
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Android.VkDeviceGetAndroidHardwareBufferPropertiesDelegate commandDelegate = commandCache.Cache.vkGetAndroidHardwareBufferPropertiesANDROID;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledBuffer, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Android.AndroidHardwareBufferProperties.MarshalFrom(&marshalledProperties);
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
        public static unsafe void GetMemoryAndroidHardwareBuffer(this SharpVk.Device extendedHandle, SharpVk.Android.MemoryGetAndroidHardwareBufferInfo info, IntPtr buffer)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo* marshalledInfo = default(SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo*);
                IntPtr* marshalledBuffer = default(IntPtr*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.MemoryGetAndroidHardwareBufferInfo>());
                info.MarshalTo(marshalledInfo);
                marshalledBuffer = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *marshalledBuffer = buffer;
                SharpVk.Interop.Android.VkDeviceGetMemoryAndroidHardwareBufferDelegate commandDelegate = commandCache.Cache.vkGetMemoryAndroidHardwareBufferANDROID;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo, marshalledBuffer);
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
    }
}
