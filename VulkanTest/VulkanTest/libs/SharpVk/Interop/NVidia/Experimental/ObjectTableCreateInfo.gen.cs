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

namespace SharpVk.Interop.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct ObjectTableCreateInfo
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
        /// The number of entry configurations that the object table supports.
        /// The following array parameters must match the size provided here.
        /// </summary>
        public uint ObjectCount; 
        
        /// <summary>
        /// An array of ObjectEntryTypeNVX providing the entry type of a given
        /// configuration.
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryType* ObjectEntryTypes; 
        
        /// <summary>
        /// An array of counts how many objects can be registered in the table.
        /// </summary>
        public uint* ObjectEntryCounts; 
        
        /// <summary>
        /// An array of bitmasks describing the binding usage of the entry. See
        /// ObjectEntryUsageFlagBitsNVX below for a description of the
        /// supported bits.
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryUsageFlags* ObjectEntryUsageFlags; 
        
        /// <summary>
        /// The maximum number of DescriptorType.UniformBuffer or
        /// DescriptorType.UniformBufferDynamic used by any single registered
        /// DescriptorSet in this table.
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor; 
        
        /// <summary>
        /// The maximum number of DescriptorType.StorageBuffer or
        /// DescriptorType.StorageBufferDynamic used by any single registered
        /// DescriptorSet in this table.
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor; 
        
        /// <summary>
        /// The maximum number of DescriptorType.StorageImage or
        /// DescriptorType.StorageTexelBuffer used by any single registered
        /// DescriptorSet in this table.
        /// </summary>
        public uint MaxStorageImagesPerDescriptor; 
        
        /// <summary>
        /// The maximum number of DescriptorType.Sampler,
        /// DescriptorType.CombinedImageSampler, DescriptorType.UniformTexelBuffer
        /// or DescriptorType.InputAttachment used by any single registered
        /// DescriptorSet in this table.
        /// </summary>
        public uint MaxSampledImagesPerDescriptor; 
        
        /// <summary>
        /// The maximum number of unique PipelineLayout used by any registered
        /// DescriptorSet or Pipeline in this table.
        /// </summary>
        public uint MaxPipelineLayouts; 
    }
}
