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
    public partial struct AttachmentDescription2
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentDescriptionFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentLoadOp LoadOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentStoreOp StoreOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentLoadOp StencilLoadOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AttachmentStoreOp StencilStoreOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout InitialLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout FinalLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AttachmentDescription2* pointer)
        {
            pointer->SType = StructureType.AttachmentDescription2;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.AttachmentDescriptionFlags);
            }
            pointer->Format = this.Format;
            pointer->Samples = this.Samples;
            pointer->LoadOp = this.LoadOp;
            pointer->StoreOp = this.StoreOp;
            pointer->StencilLoadOp = this.StencilLoadOp;
            pointer->StencilStoreOp = this.StencilStoreOp;
            pointer->InitialLayout = this.InitialLayout;
            pointer->FinalLayout = this.FinalLayout;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe AttachmentDescription2 MarshalFrom(SharpVk.Interop.Khronos.AttachmentDescription2* pointer)
        {
            AttachmentDescription2 result = default(AttachmentDescription2);
            result.Flags = pointer->Flags;
            result.Format = pointer->Format;
            result.Samples = pointer->Samples;
            result.LoadOp = pointer->LoadOp;
            result.StoreOp = pointer->StoreOp;
            result.StencilLoadOp = pointer->StencilLoadOp;
            result.StencilStoreOp = pointer->StencilStoreOp;
            result.InitialLayout = pointer->InitialLayout;
            result.FinalLayout = pointer->FinalLayout;
            return result;
        }
    }
}
