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
    public unsafe partial struct DescriptorSetLayoutBinding
    {
        /// <summary>
        /// The binding number of this entry and corresponds to a resource of
        /// the same binding number in the shader stages.
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// A DescriptorType specifying which type of resource descriptors are
        /// used for this binding.
        /// </summary>
        public SharpVk.DescriptorType DescriptorType; 
        
        /// <summary>
        /// The number of descriptors contained in the binding, accessed in a
        /// shader as an array. If descriptorCount is zero this binding entry
        /// is reserved and the resource must not be accessed from any stage
        /// via this binding within any pipeline using the set layout.
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// stageFlags member is a bitmask of ShaderStageFlagBits specifying
        /// which pipeline shader stages can access a resource for this
        /// binding. VK_SHADER_STAGE_ALL is a shorthand specifying that all
        /// defined shader stages, including any additional stages defined by
        /// extensions, can access the resource. + -- If a shader stage is not
        /// included in stageFlags, then a resource must not be accessed from
        /// that stage via this binding within any pipeline using the set
        /// layout. There are no limitations on what combinations of stages can
        /// be used by a descriptor binding, and in particular a binding can be
        /// used by both graphics stages and the compute stage. --
        /// </summary>
        public SharpVk.ShaderStageFlags StageFlags; 
        
        /// <summary>
        /// pImmutableSamplers affects initialization of samplers. If
        /// descriptorType specifies a DescriptorType.Sampler or
        /// DescriptorType.CombinedImageSampler type descriptor, then
        /// pImmutableSamplers can be used to initialize a set of _immutable
        /// samplers_. Immutable samplers are permanently bound into the set
        /// layout; later binding a sampler into an immutable sampler slot in a
        /// descriptor set is not allowed. If pImmutableSamplers is not Null,
        /// then it is considered to be an array of sampler handles that will
        /// be consumed by the set layout and used for the corresponding
        /// binding. If pImmutableSamplers is Null, then the sampler slots are
        /// dynamic and sampler handles must be bound into descriptor sets
        /// using this layout. If descriptorType is not one of these descriptor
        /// types, then pImmutableSamplers is ignored.
        /// </summary>
        public SharpVk.Interop.Sampler* ImmutableSamplers; 
    }
}
