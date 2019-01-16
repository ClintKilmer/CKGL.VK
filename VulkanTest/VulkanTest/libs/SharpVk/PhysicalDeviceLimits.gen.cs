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
    /// Structure reporting implementation-dependent physical device limits.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceLimits
    {
        /// <summary>
        /// The maximum dimension (width) of an image created with an imageType
        /// of VK_IMAGE_TYPE_1D.
        /// </summary>
        public uint MaxImageDimension1D
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum dimension (width or height) of an image created with an
        /// imageType of VK_IMAGE_TYPE_2D and without
        /// VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.
        /// </summary>
        public uint MaxImageDimension2D
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum dimension (width, height, or depth) of an image created
        /// with an imageType of VK_IMAGE_TYPE_3D.
        /// </summary>
        public uint MaxImageDimension3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum dimension (width or height) of an image created with an
        /// imageType of VK_IMAGE_TYPE_2D and with
        /// VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in flags.
        /// </summary>
        public uint MaxImageDimensionCube
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of layers (arrayLayers) for an image.
        /// </summary>
        public uint MaxImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of addressable texels for a buffer view created
        /// on a buffer which was created with the
        /// VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the usage member of
        /// the BufferCreateInfo structure.
        /// </summary>
        public uint MaxTexelBufferElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum value that can be specified in the range member of any
        /// DescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// DescriptorType.UniformBuffer or
        /// DescriptorType.UniformBufferDynamic.
        /// </summary>
        public uint MaxUniformBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum value that can be specified in the range member of any
        /// DescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// DescriptorType.StorageBuffer or
        /// DescriptorType.StorageBufferDynamic.
        /// </summary>
        public uint MaxStorageBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum size, in bytes, of the pool of push constant memory.
        /// For each of the push constant ranges indicated by the
        /// pPushConstantRanges member of the PipelineLayoutCreateInfo
        /// structure, offset + size must be less than or equal to this limit.
        /// </summary>
        public uint MaxPushConstantsSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxMemoryAllocationCount is the maximum number of device memory
        /// allocations, as created by flink:vkAllocateMemory, which can
        /// simultaneously exist.
        /// </summary>
        public uint MaxMemoryAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxSamplerAllocationCount is the maximum number of sampler objects,
        /// as created by flink:vkCreateSampler, which can simultaneously exist
        /// on a device.
        /// </summary>
        public uint MaxSamplerAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The granularity, in bytes, at which buffer or linear image
        /// resources, and optimal image resources can be bound to adjacent
        /// offsets in the same DeviceMemory object without aliasing. See
        /// Buffer-Image Granularity for more details.
        /// </summary>
        public DeviceSize BufferImageGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// The total amount of address space available, in bytes, for sparse
        /// memory resources. This is an upper bound on the sum of the size of
        /// all sparse resources, regardless of whether any memory is bound to
        /// them.
        /// </summary>
        public DeviceSize SparseAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of descriptor sets that can be simultaneously
        /// used by a pipeline. All DescriptorSet decorations in shader modules
        /// must have a value less than maxBoundDescriptorSets. See
        /// &lt;&lt;descriptorsets-sets.
        /// </summary>
        public uint MaxBoundDescriptorSets
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorSamplers is the maximum number of samplers
        /// that can be accessible to a single shader stage in a pipeline
        /// layout. Descriptors with a type of DescriptorType.Sampler or
        /// DescriptorType.CombinedImageSampler count against this limit. A
        /// descriptor is accessible to a shader stage when the stageFlags
        /// member of the DescriptorSetLayoutBinding structure has the bit for
        /// that shader stage set. See &lt;&lt;descriptorsets-sampler and
        /// &lt;&lt;descriptorsets-combinedimagesampler.
        /// </summary>
        public uint MaxPerStageDescriptorSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorUniformBuffers is the maximum number of
        /// uniform buffers that can be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// DescriptorType.UniformBuffer or DescriptorType.UniformBufferDynamic
        /// count against this limit. A descriptor is accessible to a shader
        /// stage when the stageFlags member of the DescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-uniformbuffer and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic.
        /// </summary>
        public uint MaxPerStageDescriptorUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorStorageBuffers is the maximum number of
        /// storage buffers that can be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// DescriptorType.StorageBuffer or DescriptorType.StorageBufferDynamic
        /// count against this limit. A descriptor is accessible to a pipeline
        /// shader stage when the stageFlags member of the
        /// DescriptorSetLayoutBinding structure has the bit for that shader
        /// stage set. See &lt;&lt;descriptorsets-storagebuffer and
        /// &lt;&lt;descriptorsets-storagebufferdynamic.
        /// </summary>
        public uint MaxPerStageDescriptorStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorSampledImages is the maximum number of sampled
        /// images that can be accessible to a single shader stage in a
        /// pipeline layout. Descriptors with a type of
        /// DescriptorType.CombinedImageSampler, DescriptorType.SampledImage,
        /// or DescriptorType.UniformTexelBuffer count against this limit. A
        /// descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the DescriptorSetLayoutBinding structure has
        /// the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-combinedimagesampler, &lt;&lt;descriptorsets-sampledimage,
        /// and &lt;&lt;descriptorsets-uniformtexelbuffer.
        /// </summary>
        public uint MaxPerStageDescriptorSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorStorageImages is the maximum number of storage
        /// images that can be accessible to a single shader stage in a
        /// pipeline layout. Descriptors with a type of
        /// DescriptorType.StorageImage, or DescriptorType.StorageTexelBuffer
        /// count against this limit. A descriptor is accessible to a pipeline
        /// shader stage when the stageFlags member of the
        /// DescriptorSetLayoutBinding structure has the bit for that shader
        /// stage set. See &lt;&lt;descriptorsets-storageimage, and
        /// &lt;&lt;descriptorsets-storagetexelbuffer.
        /// </summary>
        public uint MaxPerStageDescriptorStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxPerStageDescriptorInputAttachments is the maximum number of
        /// input attachments that can be accessible to a single shader stage
        /// in a pipeline layout. Descriptors with a type of
        /// DescriptorType.InputAttachment count against this limit. A
        /// descriptor is accessible to a pipeline shader stage when the
        /// stageFlags member of the DescriptorSetLayoutBinding structure has
        /// the bit for that shader stage set. These are only supported for the
        /// fragment stage. See &lt;&lt;descriptorsets-inputattachment.
        /// </summary>
        public uint MaxPerStageDescriptorInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of resources that can be accessible to a single
        /// shader stage in a pipeline layout. Descriptors with a type of
        /// DescriptorType.CombinedImageSampler, DescriptorType.SampledImage,
        /// DescriptorType.StorageImage, DescriptorType.UniformTexelBuffer,
        /// DescriptorType.StorageTexelBuffer, DescriptorType.UniformBuffer,
        /// DescriptorType.StorageBuffer, DescriptorType.UniformBufferDynamic,
        /// DescriptorType.StorageBufferDynamic, or
        /// DescriptorType.InputAttachment count against this limit. For the
        /// fragment shader stage the framebuffer color attachments also count
        /// against this limit.
        /// </summary>
        public uint MaxPerStageResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetSamplers is the maximum number of samplers that can
        /// be included in descriptor bindings in a pipeline layout across all
        /// pipeline shader stages and descriptor set numbers. Descriptors with
        /// a type of DescriptorType.Sampler or
        /// DescriptorType.CombinedImageSampler count against this limit. See
        /// &lt;&lt;descriptorsets-sampler and
        /// &lt;&lt;descriptorsets-combinedimagesampler.
        /// </summary>
        public uint MaxDescriptorSetSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetUniformBuffers is the maximum number of uniform
        /// buffers that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set
        /// numbers. Descriptors with a type of DescriptorType.UniformBuffer or
        /// DescriptorType.UniformBufferDynamic count against this limit. See
        /// &lt;&lt;descriptorsets-uniformbuffer and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetUniformBuffersDynamic is the maximum number of
        /// dynamic uniform buffers that can be included in descriptor bindings
        /// in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// DescriptorType.UniformBufferDynamic count against this limit. See
        /// &lt;&lt;descriptorsets-uniformbufferdynamic.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetStorageBuffers is the maximum number of storage
        /// buffers that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set
        /// numbers. Descriptors with a type of DescriptorType.StorageBuffer or
        /// DescriptorType.StorageBufferDynamic count against this limit. See
        /// &lt;&lt;descriptorsets-storagebuffer and
        /// &lt;&lt;descriptorsets-storagebufferdynamic.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetStorageBuffersDynamic is the maximum number of
        /// dynamic storage buffers that can be included in descriptor bindings
        /// in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// DescriptorType.StorageBufferDynamic count against this limit. See
        /// &lt;&lt;descriptorsets-storagebufferdynamic.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetSampledImages is the maximum number of sampled
        /// images that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set
        /// numbers. Descriptors with a type of
        /// DescriptorType.CombinedImageSampler, DescriptorType.SampledImage,
        /// or DescriptorType.UniformTexelBuffer count against this limit. See
        /// &lt;&lt;descriptorsets-combinedimagesampler, &lt;&lt;descriptorsets-sampledimage,
        /// and &lt;&lt;descriptorsets-uniformtexelbuffer.
        /// </summary>
        public uint MaxDescriptorSetSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetStorageImages is the maximum number of storage
        /// images that can be included in descriptor bindings in a pipeline
        /// layout across all pipeline shader stages and descriptor set
        /// numbers. Descriptors with a type of DescriptorType.StorageImage, or
        /// DescriptorType.StorageTexelBuffer count against this limit. See
        /// &lt;&lt;descriptorsets-storageimage, and
        /// &lt;&lt;descriptorsets-storagetexelbuffer.
        /// </summary>
        public uint MaxDescriptorSetStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDescriptorSetInputAttachments is the maximum number of input
        /// attachments that can be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// DescriptorType.InputAttachment count against this limit. See
        /// &lt;&lt;descriptorsets-inputattachment.
        /// </summary>
        public uint MaxDescriptorSetInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxVertexInputAttributes is the maximum number of vertex input
        /// attributes that can be specified for a graphics pipeline. These are
        /// described in the array of VertexInputAttributeDescription
        /// structures that are provided at graphics pipeline creation time via
        /// the pVertexAttributeDescriptions member of the
        /// PipelineVertexInputStateCreateInfo structure. See
        /// &lt;&lt;fxvertex-attrib and &lt;&lt;fxvertex-input.
        /// </summary>
        public uint MaxVertexInputAttributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of vertex buffers that can be specified for
        /// providing vertex attributes to a graphics pipeline. These are
        /// described in the array of VertexInputBindingDescription structures
        /// that are provided at graphics pipeline creation time via the
        /// pVertexBindingDescriptions member of the
        /// PipelineVertexInputStateCreateInfo structure. The binding member of
        /// VertexInputBindingDescription must be less than this limit. See
        /// &lt;&lt;fxvertex-input.
        /// </summary>
        public uint MaxVertexInputBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxVertexInputAttributeOffset is the maximum vertex input attribute
        /// offset that can be added to the vertex input binding stride. The
        /// offset member of the VertexInputAttributeDescription structure must
        /// be less than or equal to this limit. See &lt;&lt;fxvertex-input.
        /// </summary>
        public uint MaxVertexInputAttributeOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxVertexInputBindingStride is the maximum vertex input binding
        /// stride that can be specified in a vertex input binding. The stride
        /// member of the VertexInputBindingDescription structure must be less
        /// than or equal to this limit. See &lt;&lt;fxvertex-input.
        /// </summary>
        public uint MaxVertexInputBindingStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxVertexOutputComponents is the maximum number of components of
        /// output variables which can be output by a vertex shader. See
        /// &lt;&lt;shaders-vertex.
        /// </summary>
        public uint MaxVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationGenerationLevel is the maximum tessellation
        /// generation level supported by the fixed-function tessellation
        /// primitive generator. See &lt;&lt;tessellation.
        /// </summary>
        public uint MaxTessellationGenerationLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationPatchSize is the maximum patch size, in vertices, of
        /// patches that can be processed by the tessellation control shader
        /// and tessellation primitive generator. The patchControlPoints member
        /// of the PipelineTessellationStateCreateInfo structure specified at
        /// pipeline creation time and the value provided in the OutputVertices
        /// execution mode of shader modules must be less than or equal to this
        /// limit. See &lt;&lt;tessellation.
        /// </summary>
        public uint MaxTessellationPatchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationControlPerVertexInputComponents is the maximum
        /// number of components of input variables which can be provided as
        /// per-vertex inputs to the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationControlPerVertexOutputComponents is the maximum
        /// number of components of per-vertex output variables which can be
        /// output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationControlPerPatchOutputComponents is the maximum
        /// number of components of per-patch output variables which can be
        /// output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerPatchOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationControlTotalOutputComponents is the maximum total
        /// number of components of per-vertex and per-patch output variables
        /// which can be output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationEvaluationInputComponents is the maximum number of
        /// components of input variables which can be provided as per-vertex
        /// inputs to the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxTessellationEvaluationOutputComponents is the maximum number of
        /// components of per-vertex output variables which can be output from
        /// the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxGeometryShaderInvocations is the maximum invocation count
        /// supported for instanced geometry shaders. The value provided in the
        /// Invocations execution mode of shader modules must be less than or
        /// equal to this limit. See &lt;&lt;geometry.
        /// </summary>
        public uint MaxGeometryShaderInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxGeometryInputComponents is the maximum number of components of
        /// input variables which can be provided as inputs to the geometry
        /// shader stage.
        /// </summary>
        public uint MaxGeometryInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxGeometryOutputComponents is the maximum number of components of
        /// output variables which can be output from the geometry shader
        /// stage.
        /// </summary>
        public uint MaxGeometryOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxGeometryOutputVertices is the maximum number of vertices which
        /// can be emitted by any geometry shader.
        /// </summary>
        public uint MaxGeometryOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxGeometryTotalOutputComponents is the maximum total number of
        /// components of output, across all emitted vertices, which can be
        /// output from the geometry shader stage.
        /// </summary>
        public uint MaxGeometryTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxFragmentInputComponents is the maximum number of components of
        /// input variables which can be provided as inputs to the fragment
        /// shader stage.
        /// </summary>
        public uint MaxFragmentInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxFragmentOutputAttachments is the maximum number of output
        /// attachments which can be written to by the fragment shader stage.
        /// </summary>
        public uint MaxFragmentOutputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxFragmentDualSrcAttachments is the maximum number of output
        /// attachments which can be written to by the fragment shader stage
        /// when blending is enabled and one of the dual source blend modes is
        /// in use. See &lt;&lt;framebuffer-dsb and dualSrcBlend.
        /// </summary>
        public uint MaxFragmentDualSourceAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxFragmentCombinedOutputResources is the total number of storage
        /// buffers, storage images, and output buffers which can be used in
        /// the fragment shader stage.
        /// </summary>
        public uint MaxFragmentCombinedOutputResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxComputeSharedMemorySize is the maximum total storage size, in
        /// bytes, of all variables declared with the WorkgroupLocal storage
        /// class in shader modules (or with the shared storage qualifier in
        /// GLSL) in the compute shader stage.
        /// </summary>
        public uint MaxComputeSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxComputeWorkGroupCount[3] is the maximum number of local
        /// workgroups that can be dispatched by a single dispatch command.
        /// These three values represent the maximum number of local workgroups
        /// for the X, Y, and Z dimensions, respectively. The workgroup count
        /// parameters to the dispatch commands must be less than or equal to
        /// the corresponding limit. See &lt;&lt;dispatch.
        /// </summary>
        public (uint, uint, uint) MaxComputeWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxComputeWorkGroupInvocations is the maximum total number of
        /// compute shader invocations in a single local workgroup. The product
        /// of the X, Y, and Z sizes as specified by the LocalSize execution
        /// mode in shader modules and by the object decorated by the
        /// WorkgroupSize decoration must be less than or equal to this limit.
        /// </summary>
        public uint MaxComputeWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxComputeWorkGroupSize[3] is the maximum size of a local compute
        /// workgroup, per dimension. These three values represent the maximum
        /// local workgroup size in the X, Y, and Z dimensions, respectively.
        /// The x, y, and z sizes specified by the LocalSize execution mode and
        /// by the object decorated by the WorkgroupSize decoration in shader
        /// modules must be less than or equal to the corresponding limit.
        /// </summary>
        public (uint, uint, uint) MaxComputeWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of bits of subpixel precision in framebuffer coordinates
        /// [eq]#x~f~# and [eq]#y~f~#. See &lt;&lt;primsrast.
        /// </summary>
        public uint SubPixelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of bits of precision in the division along an axis of an
        /// image used for minification and magnification filters.
        /// [eq]#2^subTexelPrecisionBits^# is the actual number of divisions
        /// along each axis of the image represented. The filtering hardware
        /// will snap to these locations when computing the filtered results.
        /// </summary>
        public uint SubTexelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of bits of division that the LOD calculation for mipmap
        /// fetching get snapped to when determining the contribution from each
        /// mip level to the mip filtered results. [eq]#2^mipmapPrecisionBits^#
        /// is the actual number of divisions. + -- [NOTE] .Note ==== For
        /// example, if this value is 2 bits then when linearly filtering
        /// between two levels, each level could: contribute: 0%, 33%, 66%, or
        /// 100% (this is just an example and the amount of contribution
        /// should: be covered by different equations in the spec). ==== -- +
        /// </summary>
        public uint MipmapPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxDrawIndexedIndexValue is the maximum index value that can be
        /// used for indexed draw calls when using 32-bit indices. This
        /// excludes the primitive restart index value of 0xFFFFFFFF. See
        /// fullDrawIndexUint32.
        /// </summary>
        public uint MaxDrawIndexedIndexValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum draw count that is supported for indirect draw calls.
        /// See multiDrawIndirect.
        /// </summary>
        public uint MaxDrawIndirectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum absolute sampler level of detail bias. The sum of the
        /// mipLodBias member of the SamplerCreateInfo structure and the Bias
        /// operand of image sampling operations in shader modules (or 0 if no
        /// Bias operand is provided to an image sampling operation) are
        /// clamped to the range [eq]#[-maxSamplerLodBias,+maxSamplerLodBias]#.
        /// See &lt;&lt;samplers-mipLodBias.
        /// </summary>
        public float MaxSamplerLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum degree of sampler anisotropy. The maximum degree of
        /// anisotropic filtering used for an image sampling operation is the
        /// minimum of the maxAnisotropy member of the SamplerCreateInfo
        /// structure and this limit. See &lt;&lt;samplers-maxAnisotropy.
        /// </summary>
        public float MaxSamplerAnisotropy
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of active viewports. The viewportCount member of
        /// the PipelineViewportStateCreateInfo structure that is provided at
        /// pipeline creation must be less than or equal to this limit.
        /// </summary>
        public uint MaxViewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxViewportDimensions[2] are the maximum viewport dimensions in the
        /// X (width) and Y (height) dimensions, respectively. The maximum
        /// viewport dimensions must be greater than or equal to the largest
        /// image which can be created and used as a framebuffer attachment.
        /// See Controlling the Viewport.
        /// </summary>
        public (uint, uint) MaxViewportDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// viewportBoundsRange[2] is the [eq]#[minimum, maximum]# range that
        /// the corners of a viewport must be contained in. This range must be
        /// at least [eq]#[-2 {times} size, 2 {times} size - 1]#, where
        /// [eq]#size = max(maxViewportDimensions[0],
        /// maxViewportDimensions[1])#. See Controlling the Viewport. + --
        /// [NOTE] .Note ==== The intent of the viewportBoundsRange limit is to
        /// allow a maximum sized viewport to be arbitrarily shifted relative
        /// to the output target as long as at least some portion intersects.
        /// This would give a bounds limit of [eq]#[-size + 1, 2 {times} size -
        /// 1]# which would allow all possible non-empty-set intersections of
        /// the output target and the viewport. Since these numbers are
        /// typically powers of two, picking the signed number range using the
        /// smallest possible number of bits ends up with the specified range.
        /// ==== --
        /// </summary>
        public (float, float) ViewportBoundsRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of bits of subpixel precision for viewport bounds. The
        /// subpixel precision that floating-point viewport bounds are
        /// interpreted at is given by this limit.
        /// </summary>
        public uint ViewportSubPixelBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minimum required: alignment, in bytes, of host visible memory
        /// allocations within the host address space. When mapping a memory
        /// allocation with flink:vkMapMemory, subtracting offset bytes from
        /// the returned pointer will always produce an integer multiple of
        /// this limit. See &lt;&lt;memory-device-hostaccess.
        /// </summary>
        public HostSize MinMemoryMapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// minTexelBufferOffsetAlignment is the minimum required: alignment,
        /// in bytes, for the offset member of the BufferViewCreateInfo
        /// structure for texel buffers. When a buffer view is created for a
        /// buffer which was created with
        /// VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the usage member of
        /// the BufferCreateInfo structure, the offset must be an integer
        /// multiple of this limit.
        /// </summary>
        public DeviceSize MinTexelBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// minUniformBufferOffsetAlignment is the minimum required: alignment,
        /// in bytes, for the offset member of the DescriptorBufferInfo
        /// structure for uniform buffers. When a descriptor of type
        /// DescriptorType.UniformBuffer or DescriptorType.UniformBufferDynamic
        /// is updated, the offset must be an integer multiple of this limit.
        /// Similarly, dynamic offsets for uniform buffers must be multiples of
        /// this limit.
        /// </summary>
        public DeviceSize MinUniformBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// minStorageBufferOffsetAlignment is the minimum required: alignment,
        /// in bytes, for the offset member of the DescriptorBufferInfo
        /// structure for storage buffers. When a descriptor of type
        /// DescriptorType.StorageBuffer or DescriptorType.StorageBufferDynamic
        /// is updated, the offset must be an integer multiple of this limit.
        /// Similarly, dynamic offsets for storage buffers must be multiples of
        /// this limit.
        /// </summary>
        public DeviceSize MinStorageBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minimum offset value for the ConstOffset image operand of any
        /// of the OpImageSample* or OpImageFetch* image instructions.
        /// </summary>
        public int MinTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum offset value for the ConstOffset image operand of any
        /// of the OpImageSample* or OpImageFetch* image instructions.
        /// </summary>
        public uint MaxTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minimum offset value for the Offset or ConstOffsets image
        /// operands of any of the OpImage*Gather image instructions.
        /// </summary>
        public int MinTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum offset value for the Offset or ConstOffsets image
        /// operands of any of the OpImage*Gather image instructions.
        /// </summary>
        public uint MaxTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The minimum negative offset value for the offset operand of the
        /// InterpolateAtOffset extended instruction.
        /// </summary>
        public float MinInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum positive offset value for the offset operand of the
        /// InterpolateAtOffset extended instruction.
        /// </summary>
        public float MaxInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// subPixelInterpolationOffsetBits is the number of subpixel
        /// fractional bits that the x and y offsets to the InterpolateAtOffset
        /// extended instruction may be rounded to as fixed-point values.
        /// </summary>
        public uint SubPixelInterpolationOffsetBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum width for a framebuffer. The width member of the
        /// FramebufferCreateInfo structure must be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxFramebufferWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum height for a framebuffer. The height member of the
        /// FramebufferCreateInfo structure must be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxFramebufferHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum layer count for a layered framebuffer. The layers
        /// member of the FramebufferCreateInfo structure must be less than or
        /// equal to this limit.
        /// </summary>
        public uint MaxFramebufferLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// framebufferColorSampleCounts is a bitmask^1^ of SampleCountFlagBits
        /// bits indicating the color sample counts that are supported for all
        /// framebuffer color attachments.
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// framebufferDepthSampleCounts is a bitmask^1^ of SampleCountFlagBits
        /// bits indicating the supported depth sample counts for all
        /// framebuffer depth/stencil attachments, when the format includes a
        /// depth component.
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitmask^1^ of SampleCountFlagBits bits indicating the supported
        /// stencil sample counts for all framebuffer depth/stencil
        /// attachments, when the format includes a stencil component.
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitmask^1^ of SampleCountFlagBits bits indicating the supported
        /// sample counts for a framebuffer with no attachments.
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferNoAttachmentsSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of color attachments that can be used by a
        /// subpass in a render pass. The colorAttachmentCount member of the
        /// SubpassDescription structure must be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// sampledImageColorSampleCounts is a bitmask^1^ of
        /// SampleCountFlagBits bits indicating the sample counts supported for
        /// all 2D images created with ImageTiling.Optimal, usage containing
        /// VK_IMAGE_USAGE_SAMPLED_BIT, and a non-integer color format.
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// sampledImageIntegerSampleCounts is a bitmask^1^ of
        /// SampleCountFlagBits bits indicating the sample counts supported for
        /// all 2D images created with ImageTiling.Optimal, usage containing
        /// VK_IMAGE_USAGE_SAMPLED_BIT, and an integer color format.
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageIntegerSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// sampledImageDepthSampleCounts is a bitmask^1^ of
        /// SampleCountFlagBits bits indicating the sample counts supported for
        /// all 2D images created with ImageTiling.Optimal, usage containing
        /// VK_IMAGE_USAGE_SAMPLED_BIT, and a depth format.
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// sampledImageStencilSampleCounts is a bitmask^1^ of
        /// SampleCountFlagBits bits indicating the sample supported for all 2D
        /// images created with ImageTiling.Optimal, usage containing
        /// VK_IMAGE_USAGE_SAMPLED_BIT, and a stencil format.
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// storageImageSampleCounts is a bitmask^1^ of SampleCountFlagBits
        /// bits indicating the sample counts supported for all 2D images
        /// created with ImageTiling.Optimal, and usage containing
        /// VK_IMAGE_USAGE_STORAGE_BIT.
        /// </summary>
        public SharpVk.SampleCountFlags? StorageImageSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of array elements of a variable decorated with
        /// the SampleMask built-in decoration.
        /// </summary>
        public uint MaxSampleMaskWords
        {
            get;
            set;
        }
        
        /// <summary>
        /// timestampComputeAndGraphics indicates support for timestamps on all
        /// graphics and compute queues. If this limit is set to VK_TRUE, all
        /// queues that advertise the VK_QUEUE_GRAPHICS_BIT or
        /// VK_QUEUE_COMPUTE_BIT in the QueueFamilyProperties::queueFlags
        /// support QueueFamilyProperties::timestampValidBits of at least 36.
        /// See Timestamp Queries.
        /// </summary>
        public bool TimestampComputeAndGraphics
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of nanoseconds required: for a timestamp query to be
        /// incremented by 1. See Timestamp Queries.
        /// </summary>
        public float TimestampPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of clip distances that can be used in a single
        /// shader stage. The size of any array declared with the ClipDistance
        /// built-in decoration in a shader module must be less than or equal
        /// to this limit.
        /// </summary>
        public uint MaxClipDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of cull distances that can be used in a single
        /// shader stage. The size of any array declared with the CullDistance
        /// built-in decoration in a shader module must be less than or equal
        /// to this limit.
        /// </summary>
        public uint MaxCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// maxCombinedClipAndCullDistances is the maximum combined number of
        /// clip and cull distances that can be used in a single shader stage.
        /// The sum of the sizes of any pair of arrays declared with the
        /// ClipDistance and CullDistance built-in decoration used by a single
        /// shader stage in a shader module must be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxCombinedClipAndCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// discreteQueuePriorities is the number of discrete priorities that
        /// can be assigned to a queue based on the value of each member of
        /// DeviceQueueCreateInfo::pQueuePriorities. This must be at least 2,
        /// and levels must be spread evenly over the range, with at least one
        /// level at 1.0, and another at 0.0. See
        /// &lt;&lt;devsandqueues-priority.
        /// </summary>
        public uint DiscreteQueuePriorities
        {
            get;
            set;
        }
        
        /// <summary>
        /// pointSizeRange[2] is the range [eq]#[minimum,maximum]# of supported
        /// sizes for points. Values written to variables decorated with the
        /// PointSize built-in decoration are clamped to this range.
        /// </summary>
        public (float, float) PointSizeRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// lineWidthRange[2] is the range [eq]#[minimum,maximum]# of supported
        /// widths for lines. Values specified by the lineWidth member of the
        /// PipelineRasterizationStateCreateInfo or the lineWidth parameter to
        /// CommandBuffer.SetLineWidth are clamped to this range.
        /// </summary>
        public (float, float) LineWidthRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// The granularity of supported point sizes. Not all point sizes in
        /// the range defined by pointSizeRange are supported. This limit
        /// specifies the granularity (or increment) between successive
        /// supported point sizes.
        /// </summary>
        public float PointSizeGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// The granularity of supported line widths. Not all line widths in
        /// the range defined by lineWidthRange are supported. This limit
        /// specifies the granularity (or increment) between successive
        /// supported line widths.
        /// </summary>
        public float LineWidthGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// Indicates whether lines are rasterized according to the preferred
        /// method of rasterization. If set to VK_FALSE, lines may be
        /// rasterized under a relaxed set of rules. If set to VK_TRUE, lines
        /// are rasterized as per the strict definition. See Basic Line Segment
        /// Rasterization.
        /// </summary>
        public bool StrictLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// standardSampleLocations indicates whether rasterization uses the
        /// standard sample locations as documented in Multisampling. If set to
        /// VK_TRUE, the implementation uses the documented sample locations.
        /// If set to VK_FALSE, the implementation may use different sample
        /// locations.
        /// </summary>
        public bool StandardSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// optimalBufferCopyOffsetAlignment is the optimal buffer offset
        /// alignment in bytes for CommandBuffer.CopyBufferToImage and
        /// CommandBuffer.CopyImageToBuffer. The per texel alignment
        /// requirements are still enforced, this is just an additional
        /// alignment recommendation for optimal performance and power.
        /// </summary>
        public DeviceSize OptimalBufferCopyOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// optimalBufferCopyRowPitchAlignment is the optimal buffer row pitch
        /// alignment in bytes for CommandBuffer.CopyBufferToImage and
        /// CommandBuffer.CopyImageToBuffer. Row pitch is the number of bytes
        /// between texels with the same X coordinate in adjacent rows (Y
        /// coordinates differ by one). The per texel alignment requirements
        /// are still enforced, this is just an additional alignment
        /// recommendation for optimal performance and power.
        /// </summary>
        public DeviceSize OptimalBufferCopyRowPitchAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// The size and alignment in bytes that bounds concurrent access to
        /// host-mapped device memory.
        /// </summary>
        public DeviceSize NonCoherentAtomSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceLimits MarshalFrom(SharpVk.Interop.PhysicalDeviceLimits* pointer)
        {
            PhysicalDeviceLimits result = default(PhysicalDeviceLimits);
            result.MaxImageDimension1D = pointer->MaxImageDimension1D;
            result.MaxImageDimension2D = pointer->MaxImageDimension2D;
            result.MaxImageDimension3D = pointer->MaxImageDimension3D;
            result.MaxImageDimensionCube = pointer->MaxImageDimensionCube;
            result.MaxImageArrayLayers = pointer->MaxImageArrayLayers;
            result.MaxTexelBufferElements = pointer->MaxTexelBufferElements;
            result.MaxUniformBufferRange = pointer->MaxUniformBufferRange;
            result.MaxStorageBufferRange = pointer->MaxStorageBufferRange;
            result.MaxPushConstantsSize = pointer->MaxPushConstantsSize;
            result.MaxMemoryAllocationCount = pointer->MaxMemoryAllocationCount;
            result.MaxSamplerAllocationCount = pointer->MaxSamplerAllocationCount;
            result.BufferImageGranularity = pointer->BufferImageGranularity;
            result.SparseAddressSpaceSize = pointer->SparseAddressSpaceSize;
            result.MaxBoundDescriptorSets = pointer->MaxBoundDescriptorSets;
            result.MaxPerStageDescriptorSamplers = pointer->MaxPerStageDescriptorSamplers;
            result.MaxPerStageDescriptorUniformBuffers = pointer->MaxPerStageDescriptorUniformBuffers;
            result.MaxPerStageDescriptorStorageBuffers = pointer->MaxPerStageDescriptorStorageBuffers;
            result.MaxPerStageDescriptorSampledImages = pointer->MaxPerStageDescriptorSampledImages;
            result.MaxPerStageDescriptorStorageImages = pointer->MaxPerStageDescriptorStorageImages;
            result.MaxPerStageDescriptorInputAttachments = pointer->MaxPerStageDescriptorInputAttachments;
            result.MaxPerStageResources = pointer->MaxPerStageResources;
            result.MaxDescriptorSetSamplers = pointer->MaxDescriptorSetSamplers;
            result.MaxDescriptorSetUniformBuffers = pointer->MaxDescriptorSetUniformBuffers;
            result.MaxDescriptorSetUniformBuffersDynamic = pointer->MaxDescriptorSetUniformBuffersDynamic;
            result.MaxDescriptorSetStorageBuffers = pointer->MaxDescriptorSetStorageBuffers;
            result.MaxDescriptorSetStorageBuffersDynamic = pointer->MaxDescriptorSetStorageBuffersDynamic;
            result.MaxDescriptorSetSampledImages = pointer->MaxDescriptorSetSampledImages;
            result.MaxDescriptorSetStorageImages = pointer->MaxDescriptorSetStorageImages;
            result.MaxDescriptorSetInputAttachments = pointer->MaxDescriptorSetInputAttachments;
            result.MaxVertexInputAttributes = pointer->MaxVertexInputAttributes;
            result.MaxVertexInputBindings = pointer->MaxVertexInputBindings;
            result.MaxVertexInputAttributeOffset = pointer->MaxVertexInputAttributeOffset;
            result.MaxVertexInputBindingStride = pointer->MaxVertexInputBindingStride;
            result.MaxVertexOutputComponents = pointer->MaxVertexOutputComponents;
            result.MaxTessellationGenerationLevel = pointer->MaxTessellationGenerationLevel;
            result.MaxTessellationPatchSize = pointer->MaxTessellationPatchSize;
            result.MaxTessellationControlPerVertexInputComponents = pointer->MaxTessellationControlPerVertexInputComponents;
            result.MaxTessellationControlPerVertexOutputComponents = pointer->MaxTessellationControlPerVertexOutputComponents;
            result.MaxTessellationControlPerPatchOutputComponents = pointer->MaxTessellationControlPerPatchOutputComponents;
            result.MaxTessellationControlTotalOutputComponents = pointer->MaxTessellationControlTotalOutputComponents;
            result.MaxTessellationEvaluationInputComponents = pointer->MaxTessellationEvaluationInputComponents;
            result.MaxTessellationEvaluationOutputComponents = pointer->MaxTessellationEvaluationOutputComponents;
            result.MaxGeometryShaderInvocations = pointer->MaxGeometryShaderInvocations;
            result.MaxGeometryInputComponents = pointer->MaxGeometryInputComponents;
            result.MaxGeometryOutputComponents = pointer->MaxGeometryOutputComponents;
            result.MaxGeometryOutputVertices = pointer->MaxGeometryOutputVertices;
            result.MaxGeometryTotalOutputComponents = pointer->MaxGeometryTotalOutputComponents;
            result.MaxFragmentInputComponents = pointer->MaxFragmentInputComponents;
            result.MaxFragmentOutputAttachments = pointer->MaxFragmentOutputAttachments;
            result.MaxFragmentDualSourceAttachments = pointer->MaxFragmentDualSourceAttachments;
            result.MaxFragmentCombinedOutputResources = pointer->MaxFragmentCombinedOutputResources;
            result.MaxComputeSharedMemorySize = pointer->MaxComputeSharedMemorySize;
            result.MaxComputeWorkGroupCount = (pointer->MaxComputeWorkGroupCount[0], pointer->MaxComputeWorkGroupCount[1], pointer->MaxComputeWorkGroupCount[2]);
            result.MaxComputeWorkGroupInvocations = pointer->MaxComputeWorkGroupInvocations;
            result.MaxComputeWorkGroupSize = (pointer->MaxComputeWorkGroupSize[0], pointer->MaxComputeWorkGroupSize[1], pointer->MaxComputeWorkGroupSize[2]);
            result.SubPixelPrecisionBits = pointer->SubPixelPrecisionBits;
            result.SubTexelPrecisionBits = pointer->SubTexelPrecisionBits;
            result.MipmapPrecisionBits = pointer->MipmapPrecisionBits;
            result.MaxDrawIndexedIndexValue = pointer->MaxDrawIndexedIndexValue;
            result.MaxDrawIndirectCount = pointer->MaxDrawIndirectCount;
            result.MaxSamplerLodBias = pointer->MaxSamplerLodBias;
            result.MaxSamplerAnisotropy = pointer->MaxSamplerAnisotropy;
            result.MaxViewports = pointer->MaxViewports;
            result.MaxViewportDimensions = (pointer->MaxViewportDimensions[0], pointer->MaxViewportDimensions[1]);
            result.ViewportBoundsRange = (pointer->ViewportBoundsRange[0], pointer->ViewportBoundsRange[1]);
            result.ViewportSubPixelBits = pointer->ViewportSubPixelBits;
            result.MinMemoryMapAlignment = pointer->MinMemoryMapAlignment;
            result.MinTexelBufferOffsetAlignment = pointer->MinTexelBufferOffsetAlignment;
            result.MinUniformBufferOffsetAlignment = pointer->MinUniformBufferOffsetAlignment;
            result.MinStorageBufferOffsetAlignment = pointer->MinStorageBufferOffsetAlignment;
            result.MinTexelOffset = pointer->MinTexelOffset;
            result.MaxTexelOffset = pointer->MaxTexelOffset;
            result.MinTexelGatherOffset = pointer->MinTexelGatherOffset;
            result.MaxTexelGatherOffset = pointer->MaxTexelGatherOffset;
            result.MinInterpolationOffset = pointer->MinInterpolationOffset;
            result.MaxInterpolationOffset = pointer->MaxInterpolationOffset;
            result.SubPixelInterpolationOffsetBits = pointer->SubPixelInterpolationOffsetBits;
            result.MaxFramebufferWidth = pointer->MaxFramebufferWidth;
            result.MaxFramebufferHeight = pointer->MaxFramebufferHeight;
            result.MaxFramebufferLayers = pointer->MaxFramebufferLayers;
            result.FramebufferColorSampleCounts = pointer->FramebufferColorSampleCounts;
            result.FramebufferDepthSampleCounts = pointer->FramebufferDepthSampleCounts;
            result.FramebufferStencilSampleCounts = pointer->FramebufferStencilSampleCounts;
            result.FramebufferNoAttachmentsSampleCounts = pointer->FramebufferNoAttachmentsSampleCounts;
            result.MaxColorAttachments = pointer->MaxColorAttachments;
            result.SampledImageColorSampleCounts = pointer->SampledImageColorSampleCounts;
            result.SampledImageIntegerSampleCounts = pointer->SampledImageIntegerSampleCounts;
            result.SampledImageDepthSampleCounts = pointer->SampledImageDepthSampleCounts;
            result.SampledImageStencilSampleCounts = pointer->SampledImageStencilSampleCounts;
            result.StorageImageSampleCounts = pointer->StorageImageSampleCounts;
            result.MaxSampleMaskWords = pointer->MaxSampleMaskWords;
            result.TimestampComputeAndGraphics = pointer->TimestampComputeAndGraphics;
            result.TimestampPeriod = pointer->TimestampPeriod;
            result.MaxClipDistances = pointer->MaxClipDistances;
            result.MaxCullDistances = pointer->MaxCullDistances;
            result.MaxCombinedClipAndCullDistances = pointer->MaxCombinedClipAndCullDistances;
            result.DiscreteQueuePriorities = pointer->DiscreteQueuePriorities;
            result.PointSizeRange = (pointer->PointSizeRange[0], pointer->PointSizeRange[1]);
            result.LineWidthRange = (pointer->LineWidthRange[0], pointer->LineWidthRange[1]);
            result.PointSizeGranularity = pointer->PointSizeGranularity;
            result.LineWidthGranularity = pointer->LineWidthGranularity;
            result.StrictLines = pointer->StrictLines;
            result.StandardSampleLocations = pointer->StandardSampleLocations;
            result.OptimalBufferCopyOffsetAlignment = pointer->OptimalBufferCopyOffsetAlignment;
            result.OptimalBufferCopyRowPitchAlignment = pointer->OptimalBufferCopyRowPitchAlignment;
            result.NonCoherentAtomSize = pointer->NonCoherentAtomSize;
            return result;
        }
    }
}
