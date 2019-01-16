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
    public unsafe partial struct RenderPassBeginInfo
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
        /// The render pass to begin an instance of.
        /// </summary>
        public SharpVk.Interop.RenderPass RenderPass; 
        
        /// <summary>
        /// The framebuffer containing the attachments that are used with the
        /// render pass.
        /// </summary>
        public SharpVk.Interop.Framebuffer Framebuffer; 
        
        /// <summary>
        /// The render area that is affected by the render pass instance, and
        /// is described in more detail below.
        /// </summary>
        public SharpVk.Rect2D RenderArea; 
        
        /// <summary>
        /// The number of elements in pClearValues.
        /// </summary>
        public uint ClearValueCount; 
        
        /// <summary>
        /// An array of ClearValue structures that contains clear values for
        /// each attachment, if the attachment uses a loadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a
        /// depth/stencil format and uses a stencilLoadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by attachment
        /// number. Only elements corresponding to cleared attachments are
        /// used. Other elements of pClearValues are ignored.
        /// </summary>
        public SharpVk.ClearValue* ClearValues; 
    }
}
