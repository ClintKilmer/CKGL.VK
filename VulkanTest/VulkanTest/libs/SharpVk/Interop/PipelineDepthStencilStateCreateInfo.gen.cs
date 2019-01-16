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
    public unsafe partial struct PipelineDepthStencilStateCreateInfo
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
        public SharpVk.PipelineDepthStencilStateCreateFlags Flags; 
        
        /// <summary>
        /// depthTestEnable controls whether depth testing is enabled.
        /// </summary>
        public Bool32 DepthTestEnable; 
        
        /// <summary>
        /// depthWriteEnable controls whether depth writes are enabled.
        /// </summary>
        public Bool32 DepthWriteEnable; 
        
        /// <summary>
        /// The comparison operator used in the depth test.
        /// </summary>
        public SharpVk.CompareOp DepthCompareOp; 
        
        /// <summary>
        /// depthBoundsTestEnable controls whether depth bounds testing is
        /// enabled.
        /// </summary>
        public Bool32 DepthBoundsTestEnable; 
        
        /// <summary>
        /// stencilTestEnable controls whether stencil testing is enabled.
        /// </summary>
        public Bool32 StencilTestEnable; 
        
        /// <summary>
        /// front and back control the parameters of the stencil test.
        /// </summary>
        public SharpVk.StencilOpState Front; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StencilOpState Back; 
        
        /// <summary>
        /// minDepthBounds and maxDepthBounds define the range of values used
        /// in the depth bounds test.
        /// </summary>
        public float MinDepthBounds; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepthBounds; 
    }
}
