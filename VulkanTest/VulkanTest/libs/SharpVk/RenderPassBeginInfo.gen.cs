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
    /// Structure specifying render pass begin info.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct RenderPassBeginInfo
    {
        /// <summary>
        /// The render pass to begin an instance of.
        /// </summary>
        public SharpVk.RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// The framebuffer containing the attachments that are used with the
        /// render pass.
        /// </summary>
        public SharpVk.Framebuffer Framebuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The render area that is affected by the render pass instance, and
        /// is described in more detail below.
        /// </summary>
        public SharpVk.Rect2D RenderArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of ClearValue structures that contains clear values for
        /// each attachment, if the attachment uses a loadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a
        /// depth/stencil format and uses a stencilLoadOp value of
        /// VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by attachment
        /// number. Only elements corresponding to cleared attachments are
        /// used. Other elements of pClearValues are ignored.
        /// </summary>
        public SharpVk.ClearValue[] ClearValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.RenderPassBeginInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassBeginInfo;
            pointer->Next = null;
            pointer->RenderPass = this.RenderPass?.handle ?? default(SharpVk.Interop.RenderPass);
            pointer->Framebuffer = this.Framebuffer?.handle ?? default(SharpVk.Interop.Framebuffer);
            pointer->RenderArea = this.RenderArea;
            pointer->ClearValueCount = (uint)(Interop.HeapUtil.GetLength(this.ClearValues));
            if (this.ClearValues != null)
            {
                var fieldPointer = (SharpVk.ClearValue*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ClearValue>(this.ClearValues.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ClearValues.Length); index++)
                {
                    fieldPointer[index] = this.ClearValues[index];
                }
                pointer->ClearValues = fieldPointer;
            }
            else
            {
                pointer->ClearValues = null;
            }
        }
    }
}
