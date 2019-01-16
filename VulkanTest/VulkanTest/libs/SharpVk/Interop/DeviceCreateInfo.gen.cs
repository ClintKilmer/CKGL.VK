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
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct DeviceCreateInfo
    {
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.DeviceCreateFlags Flags; 
        
        /// <summary>
        /// The unsigned integer size of the pQueueCreateInfos array.
        /// </summary>
        public uint QueueCreateInfoCount; 
        
        /// <summary>
        /// An array of DeviceQueueCreateInfo structures describing the queues
        /// that are requested to be created along with the logical device.
        /// </summary>
        public SharpVk.Interop.DeviceQueueCreateInfo* QueueCreateInfos; 
        
        /// <summary>
        /// enabledLayerCount is deprecated and ignored.
        /// </summary>
        public uint EnabledLayerCount; 
        
        /// <summary>
        /// ppEnabledLayerNames is deprecated and ignored.
        /// </summary>
        public byte** EnabledLayerNames; 
        
        /// <summary>
        /// The number of device extensions to enable.
        /// </summary>
        public uint EnabledExtensionCount; 
        
        /// <summary>
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable for the created device.
        /// </summary>
        public byte** EnabledExtensionNames; 
        
        /// <summary>
        /// Null or a PhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled.
        /// </summary>
        public SharpVk.Interop.PhysicalDeviceFeatures* EnabledFeatures; 
    }
}
