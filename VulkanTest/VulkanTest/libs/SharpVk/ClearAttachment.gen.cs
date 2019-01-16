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
    /// Structure specifying a clear attachment.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearAttachment(SharpVk.ImageAspectFlags aspectMask, uint colorAttachment, SharpVk.ClearValue clearValue)
        {
            this.AspectMask = aspectMask;
            this.ColorAttachment = colorAttachment;
            this.ClearValue = clearValue;
        }
        
        /// <summary>
        /// A mask selecting the color, depth and/or stencil aspects of the
        /// attachment to be cleared. aspectMask can include
        /// VK_IMAGE_ASPECT_COLOR_BIT for color attachments,
        /// VK_IMAGE_ASPECT_DEPTH_BIT for depth/stencil attachments with a
        /// depth component, and VK_IMAGE_ASPECT_STENCIL_BIT for depth/stencil
        /// attachments with a stencil component. If the subpass's
        /// depth/stencil attachment is VK_ATTACHMENT_UNUSED, then the clear
        /// has no effect.
        /// </summary>
        public SharpVk.ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// colorAttachment is only meaningful if VK_IMAGE_ASPECT_COLOR_BIT is
        /// set in aspectMask, in which case it is an index to the
        /// pColorAttachments array in the SubpassDescription structure of the
        /// current subpass which selects the color attachment to clear. If
        /// colorAttachment is VK_ATTACHMENT_UNUSED then the clear has no
        /// effect.
        /// </summary>
        public uint ColorAttachment; 
        
        /// <summary>
        /// The color or depth/stencil value to clear the attachment to.
        /// </summary>
        public SharpVk.ClearValue ClearValue; 
    }
}
