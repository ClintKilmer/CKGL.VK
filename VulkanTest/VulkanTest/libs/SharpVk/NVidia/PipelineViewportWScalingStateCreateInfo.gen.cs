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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Structure specifying parameters of a newly created pipeline viewport W
    /// scaling state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineViewportWScalingStateCreateInfo
    {
        /// <summary>
        /// The enable for viewport W scaling
        /// </summary>
        public bool ViewportWScalingEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of ViewportWScalingNV structures which define the W
        /// scaling parameters for the corresponding viewport. If the viewport
        /// W scaling state is dynamic, this member is ignored.
        /// </summary>
        public SharpVk.NVidia.ViewportWScaling[] ViewportWScalings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PipelineViewportWScalingStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineViewportWScalingStateCreateInfo;
            pointer->Next = null;
            pointer->ViewportWScalingEnable = this.ViewportWScalingEnable;
            pointer->ViewportCount = (uint)(Interop.HeapUtil.GetLength(this.ViewportWScalings));
            if (this.ViewportWScalings != null)
            {
                var fieldPointer = (SharpVk.NVidia.ViewportWScaling*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.ViewportWScaling>(this.ViewportWScalings.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ViewportWScalings.Length); index++)
                {
                    fieldPointer[index] = this.ViewportWScalings[index];
                }
                pointer->ViewportWScalings = fieldPointer;
            }
            else
            {
                pointer->ViewportWScalings = null;
            }
        }
    }
}
