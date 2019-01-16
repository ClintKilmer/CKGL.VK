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
    public unsafe partial struct PhysicalDeviceDescriptorIndexingProperties
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
        public uint MaxUpdateAfterBindDescriptorsInAllPools; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformBufferArrayNonUniformIndexingNative; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSampledImageArrayNonUniformIndexingNative; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageBufferArrayNonUniformIndexingNative; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageArrayNonUniformIndexingNative; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RobustBufferAccessUpdateAfterBind; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 QuadDivergentImplicitLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageUpdateAfterBindResources; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments; 
    }
}
