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
    public partial struct PhysicalDeviceDescriptorIndexingFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderInputAttachmentArrayDynamicIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderUniformTexelBufferArrayDynamicIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageTexelBufferArrayDynamicIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderUniformBufferArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSampledImageArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageBufferArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageImageArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderInputAttachmentArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderUniformTexelBufferArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageTexelBufferArrayNonUniformIndexing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingUniformBufferUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingSampledImageUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingStorageImageUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingStorageBufferUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingUniformTexelBufferUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingStorageTexelBufferUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingUpdateUnusedWhilePending
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingPartiallyBound
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DescriptorBindingVariableDescriptorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RuntimeDescriptorArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorIndexingFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;
            pointer->Next = null;
            pointer->ShaderInputAttachmentArrayDynamicIndexing = this.ShaderInputAttachmentArrayDynamicIndexing;
            pointer->ShaderUniformTexelBufferArrayDynamicIndexing = this.ShaderUniformTexelBufferArrayDynamicIndexing;
            pointer->ShaderStorageTexelBufferArrayDynamicIndexing = this.ShaderStorageTexelBufferArrayDynamicIndexing;
            pointer->ShaderUniformBufferArrayNonUniformIndexing = this.ShaderUniformBufferArrayNonUniformIndexing;
            pointer->ShaderSampledImageArrayNonUniformIndexing = this.ShaderSampledImageArrayNonUniformIndexing;
            pointer->ShaderStorageBufferArrayNonUniformIndexing = this.ShaderStorageBufferArrayNonUniformIndexing;
            pointer->ShaderStorageImageArrayNonUniformIndexing = this.ShaderStorageImageArrayNonUniformIndexing;
            pointer->ShaderInputAttachmentArrayNonUniformIndexing = this.ShaderInputAttachmentArrayNonUniformIndexing;
            pointer->ShaderUniformTexelBufferArrayNonUniformIndexing = this.ShaderUniformTexelBufferArrayNonUniformIndexing;
            pointer->ShaderStorageTexelBufferArrayNonUniformIndexing = this.ShaderStorageTexelBufferArrayNonUniformIndexing;
            pointer->DescriptorBindingUniformBufferUpdateAfterBind = this.DescriptorBindingUniformBufferUpdateAfterBind;
            pointer->DescriptorBindingSampledImageUpdateAfterBind = this.DescriptorBindingSampledImageUpdateAfterBind;
            pointer->DescriptorBindingStorageImageUpdateAfterBind = this.DescriptorBindingStorageImageUpdateAfterBind;
            pointer->DescriptorBindingStorageBufferUpdateAfterBind = this.DescriptorBindingStorageBufferUpdateAfterBind;
            pointer->DescriptorBindingUniformTexelBufferUpdateAfterBind = this.DescriptorBindingUniformTexelBufferUpdateAfterBind;
            pointer->DescriptorBindingStorageTexelBufferUpdateAfterBind = this.DescriptorBindingStorageTexelBufferUpdateAfterBind;
            pointer->DescriptorBindingUpdateUnusedWhilePending = this.DescriptorBindingUpdateUnusedWhilePending;
            pointer->DescriptorBindingPartiallyBound = this.DescriptorBindingPartiallyBound;
            pointer->DescriptorBindingVariableDescriptorCount = this.DescriptorBindingVariableDescriptorCount;
            pointer->RuntimeDescriptorArray = this.RuntimeDescriptorArray;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceDescriptorIndexingFeatures MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceDescriptorIndexingFeatures* pointer)
        {
            PhysicalDeviceDescriptorIndexingFeatures result = default(PhysicalDeviceDescriptorIndexingFeatures);
            result.ShaderInputAttachmentArrayDynamicIndexing = pointer->ShaderInputAttachmentArrayDynamicIndexing;
            result.ShaderUniformTexelBufferArrayDynamicIndexing = pointer->ShaderUniformTexelBufferArrayDynamicIndexing;
            result.ShaderStorageTexelBufferArrayDynamicIndexing = pointer->ShaderStorageTexelBufferArrayDynamicIndexing;
            result.ShaderUniformBufferArrayNonUniformIndexing = pointer->ShaderUniformBufferArrayNonUniformIndexing;
            result.ShaderSampledImageArrayNonUniformIndexing = pointer->ShaderSampledImageArrayNonUniformIndexing;
            result.ShaderStorageBufferArrayNonUniformIndexing = pointer->ShaderStorageBufferArrayNonUniformIndexing;
            result.ShaderStorageImageArrayNonUniformIndexing = pointer->ShaderStorageImageArrayNonUniformIndexing;
            result.ShaderInputAttachmentArrayNonUniformIndexing = pointer->ShaderInputAttachmentArrayNonUniformIndexing;
            result.ShaderUniformTexelBufferArrayNonUniformIndexing = pointer->ShaderUniformTexelBufferArrayNonUniformIndexing;
            result.ShaderStorageTexelBufferArrayNonUniformIndexing = pointer->ShaderStorageTexelBufferArrayNonUniformIndexing;
            result.DescriptorBindingUniformBufferUpdateAfterBind = pointer->DescriptorBindingUniformBufferUpdateAfterBind;
            result.DescriptorBindingSampledImageUpdateAfterBind = pointer->DescriptorBindingSampledImageUpdateAfterBind;
            result.DescriptorBindingStorageImageUpdateAfterBind = pointer->DescriptorBindingStorageImageUpdateAfterBind;
            result.DescriptorBindingStorageBufferUpdateAfterBind = pointer->DescriptorBindingStorageBufferUpdateAfterBind;
            result.DescriptorBindingUniformTexelBufferUpdateAfterBind = pointer->DescriptorBindingUniformTexelBufferUpdateAfterBind;
            result.DescriptorBindingStorageTexelBufferUpdateAfterBind = pointer->DescriptorBindingStorageTexelBufferUpdateAfterBind;
            result.DescriptorBindingUpdateUnusedWhilePending = pointer->DescriptorBindingUpdateUnusedWhilePending;
            result.DescriptorBindingPartiallyBound = pointer->DescriptorBindingPartiallyBound;
            result.DescriptorBindingVariableDescriptorCount = pointer->DescriptorBindingVariableDescriptorCount;
            result.RuntimeDescriptorArray = pointer->RuntimeDescriptorArray;
            return result;
        }
    }
}
