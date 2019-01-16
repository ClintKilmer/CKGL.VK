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
    public unsafe partial struct GraphicsPipelineCreateInfo
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
        /// A bitmask of PipelineCreateFlagBits controlling how the pipeline
        /// will be generated, as described below.
        /// </summary>
        public SharpVk.PipelineCreateFlags Flags; 
        
        /// <summary>
        /// The number of entries in the pStages array.
        /// </summary>
        public uint StageCount; 
        
        /// <summary>
        /// An array of size stageCount structures of type
        /// PipelineShaderStageCreateInfo describing the set of the shader
        /// stages to be included in the graphics pipeline.
        /// </summary>
        public SharpVk.Interop.PipelineShaderStageCreateInfo* Stages; 
        
        /// <summary>
        /// An instance of the PipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public SharpVk.Interop.PipelineVertexInputStateCreateInfo* VertexInputState; 
        
        /// <summary>
        /// An instance of the PipelineInputAssemblyStateCreateInfo structure
        /// which determines input assembly behavior.
        /// </summary>
        public SharpVk.Interop.PipelineInputAssemblyStateCreateInfo* InputAssemblyState; 
        
        /// <summary>
        /// An instance of the PipelineTessellationStateCreateInfo structure,
        /// or Null if the pipeline does not include a tessellation control
        /// shader stage and tessellation evaluation shader stage.
        /// </summary>
        public SharpVk.Interop.PipelineTessellationStateCreateInfo* TessellationState; 
        
        /// <summary>
        /// An instance of the PipelineViewportStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.Interop.PipelineViewportStateCreateInfo* ViewportState; 
        
        /// <summary>
        /// An instance of the PipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public SharpVk.Interop.PipelineRasterizationStateCreateInfo* RasterizationState; 
        
        /// <summary>
        /// An instance of the PipelineMultisampleStateCreateInfo, or Null if
        /// the pipeline has rasterization disabled.
        /// </summary>
        public SharpVk.Interop.PipelineMultisampleStateCreateInfo* MultisampleState; 
        
        /// <summary>
        /// An instance of the PipelineDepthStencilStateCreateInfo structure,
        /// or Null if the pipeline has rasterization disabled or if the
        /// subpass of the render pass the pipeline is created against does not
        /// use a depth/stencil attachment.
        /// </summary>
        public SharpVk.Interop.PipelineDepthStencilStateCreateInfo* DepthStencilState; 
        
        /// <summary>
        /// An instance of the PipelineColorBlendStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled or if the subpass
        /// of the render pass the pipeline is created against does not use any
        /// color attachments.
        /// </summary>
        public SharpVk.Interop.PipelineColorBlendStateCreateInfo* ColorBlendState; 
        
        /// <summary>
        /// A pointer to PipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can
        /// be changed independently of the pipeline state. This can be Null,
        /// which means no state in the pipeline is considered dynamic.
        /// </summary>
        public SharpVk.Interop.PipelineDynamicStateCreateInfo* DynamicState; 
        
        /// <summary>
        /// The description of binding locations used by both the pipeline and
        /// descriptor sets used with the pipeline.
        /// </summary>
        public SharpVk.Interop.PipelineLayout Layout; 
        
        /// <summary>
        /// A handle to a render pass object describing the environment in
        /// which the pipeline will be used; the pipeline must only be used
        /// with an instance of any render pass compatible with the one
        /// provided.
        /// </summary>
        public SharpVk.Interop.RenderPass RenderPass; 
        
        /// <summary>
        /// The index of the subpass in the render pass where this pipeline
        /// will be used.
        /// </summary>
        public uint Subpass; 
        
        /// <summary>
        /// A pipeline to derive from.
        /// </summary>
        public SharpVk.Interop.Pipeline BasePipelineHandle; 
        
        /// <summary>
        /// An index into the pCreateInfos parameter to use as a pipeline to
        /// derive from.
        /// </summary>
        public int BasePipelineIndex; 
    }
}
