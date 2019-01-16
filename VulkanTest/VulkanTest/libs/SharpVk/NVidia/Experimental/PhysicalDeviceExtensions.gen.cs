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
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// Returns device-generated commands related properties of a physical
        /// device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.Experimental.DeviceGeneratedCommandsLimits GetGeneratedCommandsProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.NVidia.Experimental.DeviceGeneratedCommandsFeatures features)
        {
            try
            {
                SharpVk.NVidia.Experimental.DeviceGeneratedCommandsLimits result = default(SharpVk.NVidia.Experimental.DeviceGeneratedCommandsLimits);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures* marshalledFeatures = default(SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures*);
                SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsLimits marshalledLimits = default(SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsLimits);
                commandCache = extendedHandle.commandCache;
                marshalledFeatures = (SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.DeviceGeneratedCommandsFeatures>());
                features.MarshalTo(marshalledFeatures);
                SharpVk.Interop.NVidia.Experimental.VkPhysicalDeviceGetGeneratedCommandsPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX;
                commandDelegate(extendedHandle.handle, marshalledFeatures, &marshalledLimits);
                result = SharpVk.NVidia.Experimental.DeviceGeneratedCommandsLimits.MarshalFrom(&marshalledLimits);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
