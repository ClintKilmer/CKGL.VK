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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDescription2
    {
        /// <summary>
        /// 
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
        public uint ViewMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentReference2[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentReference2[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentReference2[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentReference2? DepthStencilAttachment
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
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.SubpassDescription2* pointer)
        {
            pointer->SType = StructureType.SubpassDescription2;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SubpassDescriptionFlags);
            }
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->ViewMask = this.ViewMask;
            pointer->InputAttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.InputAttachments));
            if (this.InputAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AttachmentReference2>(this.InputAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.InputAttachments.Length); index++)
                {
                    this.InputAttachments[index].MarshalTo(&fieldPointer[index]);
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
                var fieldPointer = (SharpVk.Interop.Khronos.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AttachmentReference2>(this.ColorAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorAttachments.Length); index++)
                {
                    this.ColorAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ColorAttachments = fieldPointer;
            }
            else
            {
                pointer->ColorAttachments = null;
            }
            if (this.ResolveAttachments != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.AttachmentReference2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AttachmentReference2>(this.ResolveAttachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ResolveAttachments.Length); index++)
                {
                    this.ResolveAttachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ResolveAttachments = fieldPointer;
            }
            else
            {
                pointer->ResolveAttachments = null;
            }
            if (this.DepthStencilAttachment != null)
            {
                pointer->DepthStencilAttachment = (SharpVk.Interop.Khronos.AttachmentReference2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AttachmentReference2>());
                this.DepthStencilAttachment.Value.MarshalTo(pointer->DepthStencilAttachment);
            }
            else
            {
                pointer->DepthStencilAttachment = default(SharpVk.Interop.Khronos.AttachmentReference2*);
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
