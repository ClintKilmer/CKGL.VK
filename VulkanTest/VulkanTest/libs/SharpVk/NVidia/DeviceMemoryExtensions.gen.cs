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
    public static class DeviceMemoryExtensions
    {
        /// <summary>
        /// Retrieve Win32 handle to a device memory object.
        /// </summary>
        /// <param name="extendedHandle">
        /// The DeviceMemory handle to extend.
        /// </param>
        public static unsafe IntPtr GetWin32Handle(this SharpVk.DeviceMemory extendedHandle, SharpVk.NVidia.ExternalMemoryHandleTypeFlags handleType)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkDeviceMemoryGetWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandleNV;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, handleType, &marshalledHandle);
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
    }
}
