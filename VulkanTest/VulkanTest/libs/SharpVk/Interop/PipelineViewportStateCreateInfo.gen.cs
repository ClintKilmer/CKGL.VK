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
    public unsafe partial struct PipelineViewportStateCreateInfo
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
        public SharpVk.PipelineViewportStateCreateFlags Flags; 
        
        /// <summary>
        /// The number of viewports used by the pipeline.
        /// </summary>
        public uint ViewportCount; 
        
        /// <summary>
        /// An array of Viewport structures, defining the viewport transforms.
        /// If the viewport state is dynamic, this member is ignored.
        /// </summary>
        public SharpVk.Viewport* Viewports; 
        
        /// <summary>
        /// The number of scissors and must match the number of viewports.
        /// </summary>
        public uint ScissorCount; 
        
        /// <summary>
        /// An array of Rect2D structures which define the rectangular bounds
        /// of the scissor for the corresponding viewport. If the scissor state
        /// is dynamic, this member is ignored.
        /// </summary>
        public SharpVk.Rect2D* Scissors; 
    }
}
