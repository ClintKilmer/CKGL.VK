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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Determine image capabilities compatible with external memory handle
        /// types.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.ExternalImageFormatProperties GetExternalImageFormatProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Format format, SharpVk.ImageType type, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?), SharpVk.NVidia.ExternalMemoryHandleTypeFlags? externalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags?))
        {
            try
            {
                SharpVk.NVidia.ExternalImageFormatProperties result = default(SharpVk.NVidia.ExternalImageFormatProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.ImageCreateFlags marshalledFlags = default(SharpVk.ImageCreateFlags);
                SharpVk.NVidia.ExternalMemoryHandleTypeFlags marshalledExternalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags);
                SharpVk.NVidia.ExternalImageFormatProperties marshalledExternalImageFormatProperties = default(SharpVk.NVidia.ExternalImageFormatProperties);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.ImageCreateFlags);
                }
                if (externalHandleType != null)
                {
                    marshalledExternalHandleType = externalHandleType.Value;
                }
                else
                {
                    marshalledExternalHandleType = default(SharpVk.NVidia.ExternalMemoryHandleTypeFlags);
                }
                SharpVk.Interop.NVidia.VkPhysicalDeviceGetExternalImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
                Result methodResult = commandDelegate(extendedHandle.handle, format, type, tiling, usage, marshalledFlags, marshalledExternalHandleType, &marshalledExternalImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledExternalImageFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
