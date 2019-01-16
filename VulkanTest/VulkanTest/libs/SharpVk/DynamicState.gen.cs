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

namespace SharpVk
{
    /// <summary>
    /// Indicate which dynamic state is taken from dynamic state commands.
    /// </summary>
    public enum DynamicState
    {
        /// <summary>
        /// Indicates that the pViewports state in
        /// PipelineViewportStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetViewport before any draw commands.
        /// The number of viewports used by a pipeline is still specified by
        /// the viewportCount member of PipelineViewportStateCreateInfo.
        /// </summary>
        Viewport = 0, 
        
        /// <summary>
        /// Indicates that the pScissors state in
        /// PipelineViewportStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetScissor before any draw commands.
        /// The number of scissor rectangles used by a pipeline is still
        /// specified by the scissorCount member of
        /// PipelineViewportStateCreateInfo.
        /// </summary>
        Scissor = 1, 
        
        /// <summary>
        /// Indicates that the lineWidth state in
        /// PipelineRasterizationStateCreateInfo will be ignored and must be
        /// set dynamically with flink:vkCmdSetLineWidth before any draw
        /// commands that generate line primitives for the rasterizer.
        /// </summary>
        LineWidth = 2, 
        
        /// <summary>
        /// Indicates that the depthBiasConstantFactor, depthBiasClamp and
        /// depthBiasSlopeFactor states in PipelineRasterizationStateCreateInfo
        /// will be ignored and must be set dynamically with
        /// flink:vkCmdSetDepthBias before any draws are performed with
        /// depthBiasEnable in PipelineRasterizationStateCreateInfo set to
        /// VK_TRUE.
        /// </summary>
        DepthBias = 3, 
        
        /// <summary>
        /// Indicates that the blendConstants state in
        /// PipelineColorBlendStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetBlendConstants before any draws are
        /// performed with a pipeline state with
        /// PipelineColorBlendAttachmentState member blendEnable set to VK_TRUE
        /// and any of the blend functions using a constant blend color.
        /// </summary>
        BlendConstants = 4, 
        
        /// <summary>
        /// Indicates that the minDepthBounds and maxDepthBounds states of
        /// PipelineDepthStencilStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetDepthBounds before any draws are
        /// performed with a pipeline state with
        /// PipelineDepthStencilStateCreateInfo member depthBoundsTestEnable
        /// set to VK_TRUE.
        /// </summary>
        DepthBounds = 5, 
        
        /// <summary>
        /// Indicates that the compareMask state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilCompareMask before any draws are performed
        /// with a pipeline state with PipelineDepthStencilStateCreateInfo
        /// member stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilCompareMask = 6, 
        
        /// <summary>
        /// Indicates that the writeMask state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilWriteMask before any draws are performed with
        /// a pipeline state with PipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilWriteMask = 7, 
        
        /// <summary>
        /// Indicates that the reference state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilReference before any draws are performed with
        /// a pipeline state with PipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilReference = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportWScaling = 1000087000, 
        
        /// <summary>
        /// 
        /// </summary>
        DiscardRectangle = 1000099000, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleLocations = 1000143000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportShadingRatePalette = 1000164004, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportCoarseSampleOrder = 1000164006, 
        
        /// <summary>
        /// 
        /// </summary>
        ExclusiveScissor = 1000205001, 
    }
}
