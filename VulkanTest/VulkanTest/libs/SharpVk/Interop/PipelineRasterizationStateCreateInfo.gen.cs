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
    public unsafe partial struct PipelineRasterizationStateCreateInfo
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
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineRasterizationStateCreateFlags Flags; 
        
        /// <summary>
        /// depthClampEnable controls whether to clamp the fragment's depth
        /// values instead of clipping primitives to the z planes of the
        /// frustum, as described in Primitive Clipping.
        /// </summary>
        public Bool32 DepthClampEnable; 
        
        /// <summary>
        /// rasterizerDiscardEnable controls whether primitives are discarded
        /// immediately before the rasterization stage.
        /// </summary>
        public Bool32 RasterizerDiscardEnable; 
        
        /// <summary>
        /// The triangle rendering mode. See PolygonMode.
        /// </summary>
        public SharpVk.PolygonMode PolygonMode; 
        
        /// <summary>
        /// The triangle facing direction used for primitive culling. See
        /// CullModeFlagBits.
        /// </summary>
        public SharpVk.CullModeFlags CullMode; 
        
        /// <summary>
        /// The front-facing triangle orientation to be used for culling. See
        /// FrontFace.
        /// </summary>
        public SharpVk.FrontFace FrontFace; 
        
        /// <summary>
        /// depthBiasEnable controls whether to bias fragment depth values.
        /// </summary>
        public Bool32 DepthBiasEnable; 
        
        /// <summary>
        /// A scalar factor controlling the constant depth value added to each
        /// fragment.
        /// </summary>
        public float DepthBiasConstantFactor; 
        
        /// <summary>
        /// The maximum (or minimum) depth bias of a fragment.
        /// </summary>
        public float DepthBiasClamp; 
        
        /// <summary>
        /// A scalar factor applied to a fragment's slope in depth bias
        /// calculations.
        /// </summary>
        public float DepthBiasSlopeFactor; 
        
        /// <summary>
        /// The width of rasterized line segments.
        /// </summary>
        public float LineWidth; 
    }
}
