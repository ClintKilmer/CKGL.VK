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
    public unsafe partial struct FramebufferCreateInfo
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
        public SharpVk.FramebufferCreateFlags Flags; 
        
        /// <summary>
        /// A render pass that defines what render passes the framebuffer will
        /// be compatible with.
        /// </summary>
        public SharpVk.Interop.RenderPass RenderPass; 
        
        /// <summary>
        /// The number of attachments.
        /// </summary>
        public uint AttachmentCount; 
        
        /// <summary>
        /// An array of ImageView handles, each of which will be used as the
        /// corresponding attachment in a render pass instance.
        /// </summary>
        public SharpVk.Interop.ImageView* Attachments; 
        
        /// <summary>
        /// width, height and layers define the dimensions of the framebuffer.
        /// If the render pass uses multiview, then layers must be one and each
        /// attachment requires a number of layers that is greater than the
        /// maximum bit index set in the view mask in the subpasses in which it
        /// is used.
        /// </summary>
        public uint Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Layers; 
    }
}
