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

namespace SharpVk.Interop.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceDescriptorIndexingFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInputAttachmentArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformTexelBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageTexelBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformBufferArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSampledImageArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageBufferArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingUniformBufferUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingSampledImageUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingStorageImageUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingStorageBufferUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingUpdateUnusedWhilePending; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingPartiallyBound; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DescriptorBindingVariableDescriptorCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RuntimeDescriptorArray; 
    }
}
