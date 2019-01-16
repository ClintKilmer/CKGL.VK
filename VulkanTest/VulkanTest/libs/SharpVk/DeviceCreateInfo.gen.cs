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

namespace SharpVk
{
    /// <summary>
    /// Structure specifying parameters of a newly created device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DeviceCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.DeviceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of DeviceQueueCreateInfo structures describing the queues
        /// that are requested to be created along with the logical device.
        /// </summary>
        public SharpVk.DeviceQueueCreateInfo[] QueueCreateInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// ppEnabledLayerNames is deprecated and ignored.
        /// </summary>
        public ArrayProxy<string> EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable for the created device.
        /// </summary>
        public ArrayProxy<string> EnabledExtensionNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// Null or a PhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled.
        /// </summary>
        public SharpVk.PhysicalDeviceFeatures? EnabledFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.DeviceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DeviceCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.DeviceCreateFlags);
            }
            pointer->QueueCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(this.QueueCreateInfos));
            if (this.QueueCreateInfos != null)
            {
                var fieldPointer = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceQueueCreateInfo>(this.QueueCreateInfos.Length).ToPointer());
                for(int index = 0; index < (uint)(this.QueueCreateInfos.Length); index++)
                {
                    this.QueueCreateInfos[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->QueueCreateInfos = fieldPointer;
            }
            else
            {
                pointer->QueueCreateInfos = null;
            }
            pointer->EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(this.EnabledLayerNames));
            pointer->EnabledLayerNames = Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
            pointer->EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(this.EnabledExtensionNames));
            pointer->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
            if (this.EnabledFeatures != null)
            {
                pointer->EnabledFeatures = (SharpVk.Interop.PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures>());
                this.EnabledFeatures.Value.MarshalTo(pointer->EnabledFeatures);
            }
            else
            {
                pointer->EnabledFeatures = default(SharpVk.Interop.PhysicalDeviceFeatures*);
            }
        }
    }
}
