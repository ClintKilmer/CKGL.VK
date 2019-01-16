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
    /// Structure specifying a subpass description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDescription
    {
        /// <summary>
        /// A bitmask indicating usage of the subpass. Bits which can be set
        /// include: + --
        /// </summary>
        public SharpVk.SubpassDescriptionFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentReference? DepthStencilAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] PreserveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.SubpassDescription* pointer)
        {
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SubpassDescriptionFlags);
            }
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->InputAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.InputAttachments));
            if (this.InputAttachments != null)
            {
                var fieldPointer = (SharpVk.AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<SharpVk.AttachmentReference>(this.InputAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.InputAttachments.Length); index++)
                {
                    fieldPointer[index] = this.InputAttachments[index];
                }
                pointer->InputAttachments = fieldPointer;
            }
            else
            {
                pointer->InputAttachments = null;
            }
            pointer->ColorAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.ColorAttachments));
            if (this.ColorAttachments != null)
            {
                var fieldPointer = (SharpVk.AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<SharpVk.AttachmentReference>(this.ColorAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorAttachments.Length); index++)
                {
                    fieldPointer[index] = this.ColorAttachments[index];
                }
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (this.ResolveAttachments != null)
            {
                var fieldPointer = (SharpVk.AttachmentReference*)(Interop.HeapUtil.AllocateAndClear<SharpVk.AttachmentReference>(this.ResolveAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ResolveAttachments.Length); index++)
                {
                    fieldPointer[index] = this.ResolveAttachments[index];
                }
                pointer->ResolveAttachments = fieldPointer;
            }
            else
            {
                pointer->ResolveAttachments = null;
            }
            if (this.DepthStencilAttachment != null)
            {
                pointer->DepthStencilAttachment = (SharpVk.AttachmentReference*)(Interop.HeapUtil.Allocate<SharpVk.AttachmentReference>());
                *pointer->DepthStencilAttachment = this.DepthStencilAttachment.Value;
            }
            else
            {
                pointer->DepthStencilAttachment = default(SharpVk.AttachmentReference*);
            }
            pointer->PreserveAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.PreserveAttachments));
            if (this.PreserveAttachments != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.PreserveAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PreserveAttachments.Length); index++)
                {
                    fieldPointer[index] = this.PreserveAttachments[index];
                }
                pointer->PreserveAttachments = fieldPointer;
            }
            else
            {
                pointer->PreserveAttachments = null;
            }
        }
    }
}
