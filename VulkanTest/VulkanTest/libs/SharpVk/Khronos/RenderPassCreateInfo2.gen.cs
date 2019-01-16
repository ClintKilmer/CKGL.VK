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
    public partial struct RenderPassCreateInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.RenderPassCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AttachmentDescription2[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SubpassDescription2[] Subpasses
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SubpassDependency2[] Dependencies
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] CorrelatedViewMasks
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.RenderPassCreateInfo2* pointer)
        {
            pointer->SType = StructureType.RenderPassCreateInfo2;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.RenderPassCreateFlags);
            }
            pointer->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.Attachments));
            if (this.Attachments != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.AttachmentDescription2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AttachmentDescription2>(this.Attachments.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Attachments.Length); index++)
                {
                    this.Attachments[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Attachments = fieldPointer;
            }
            else
            {
                pointer->Attachments = null;
            }
            pointer->SubpassCount = (uint)(Interop.HeapUtil.GetLength(this.Subpasses));
            if (this.Subpasses != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.SubpassDescription2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SubpassDescription2>(this.Subpasses.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Subpasses.Length); index++)
                {
                    this.Subpasses[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Subpasses = fieldPointer;
            }
            else
            {
                pointer->Subpasses = null;
            }
            pointer->DependencyCount = (uint)(Interop.HeapUtil.GetLength(this.Dependencies));
            if (this.Dependencies != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.SubpassDependency2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SubpassDependency2>(this.Dependencies.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Dependencies.Length); index++)
                {
                    this.Dependencies[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Dependencies = fieldPointer;
            }
            else
            {
                pointer->Dependencies = null;
            }
            pointer->CorrelatedViewMaskCount = (uint)(Interop.HeapUtil.GetLength(this.CorrelatedViewMasks));
            if (this.CorrelatedViewMasks != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.CorrelatedViewMasks.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CorrelatedViewMasks.Length); index++)
                {
                    fieldPointer[index] = this.CorrelatedViewMasks[index];
                }
                pointer->CorrelatedViewMasks = fieldPointer;
            }
            else
            {
                pointer->CorrelatedViewMasks = null;
            }
        }
    }
}
