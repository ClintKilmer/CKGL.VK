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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceDescriptorIndexingProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUpdateAfterBindDescriptorsInAllPools
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderUniformBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSampledImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderInputAttachmentArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RobustBufferAccessUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool QuadDivergentImplicitLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageUpdateAfterBindResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceDescriptorIndexingProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorIndexingProperties* pointer)
        {
            PhysicalDeviceDescriptorIndexingProperties result = default(PhysicalDeviceDescriptorIndexingProperties);
            result.MaxUpdateAfterBindDescriptorsInAllPools = pointer->MaxUpdateAfterBindDescriptorsInAllPools;
            result.ShaderUniformBufferArrayNonUniformIndexingNative = pointer->ShaderUniformBufferArrayNonUniformIndexingNative;
            result.ShaderSampledImageArrayNonUniformIndexingNative = pointer->ShaderSampledImageArrayNonUniformIndexingNative;
            result.ShaderStorageBufferArrayNonUniformIndexingNative = pointer->ShaderStorageBufferArrayNonUniformIndexingNative;
            result.ShaderStorageImageArrayNonUniformIndexingNative = pointer->ShaderStorageImageArrayNonUniformIndexingNative;
            result.ShaderInputAttachmentArrayNonUniformIndexingNative = pointer->ShaderInputAttachmentArrayNonUniformIndexingNative;
            result.RobustBufferAccessUpdateAfterBind = pointer->RobustBufferAccessUpdateAfterBind;
            result.QuadDivergentImplicitLod = pointer->QuadDivergentImplicitLod;
            result.MaxPerStageDescriptorUpdateAfterBindSamplers = pointer->MaxPerStageDescriptorUpdateAfterBindSamplers;
            result.MaxPerStageDescriptorUpdateAfterBindUniformBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindStorageBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindSampledImages = pointer->MaxPerStageDescriptorUpdateAfterBindSampledImages;
            result.MaxPerStageDescriptorUpdateAfterBindStorageImages = pointer->MaxPerStageDescriptorUpdateAfterBindStorageImages;
            result.MaxPerStageDescriptorUpdateAfterBindInputAttachments = pointer->MaxPerStageDescriptorUpdateAfterBindInputAttachments;
            result.MaxPerStageUpdateAfterBindResources = pointer->MaxPerStageUpdateAfterBindResources;
            result.MaxDescriptorSetUpdateAfterBindSamplers = pointer->MaxDescriptorSetUpdateAfterBindSamplers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffers = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffers = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffers;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindSampledImages = pointer->MaxDescriptorSetUpdateAfterBindSampledImages;
            result.MaxDescriptorSetUpdateAfterBindStorageImages = pointer->MaxDescriptorSetUpdateAfterBindStorageImages;
            result.MaxDescriptorSetUpdateAfterBindInputAttachments = pointer->MaxDescriptorSetUpdateAfterBindInputAttachments;
            return result;
        }
    }
}
