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
    /// Structure specifying parameters of a newly created pipeline color blend
    /// state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineColorBlendStateCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineColorBlendStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// logicOpEnable controls whether to apply Logical Operations.
        /// </summary>
        public bool LogicOpEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// logicOp selects which logical operation to apply.
        /// </summary>
        public SharpVk.LogicOp LogicOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pAttachments: is array of per target attachment states.
        /// </summary>
        public SharpVk.PipelineColorBlendAttachmentState[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of four values used as the R, G, B, and A components of
        /// the blend constant that are used in blending, depending on the
        /// blend factor.
        /// </summary>
        public (float, float, float, float) BlendConstants
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineColorBlendStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineColorBlendStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineColorBlendStateCreateFlags);
            }
            pointer->LogicOpEnable = this.LogicOpEnable;
            pointer->LogicOp = this.LogicOp;
            pointer->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(this.Attachments));
            if (this.Attachments != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelineColorBlendAttachmentState*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineColorBlendAttachmentState>(this.Attachments.Length).ToPointer());
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
            pointer->BlendConstants[0] = this.BlendConstants.Item1;
            pointer->BlendConstants[1] = this.BlendConstants.Item2;
            pointer->BlendConstants[2] = this.BlendConstants.Item3;
            pointer->BlendConstants[3] = this.BlendConstants.Item4;
        }
    }
}
