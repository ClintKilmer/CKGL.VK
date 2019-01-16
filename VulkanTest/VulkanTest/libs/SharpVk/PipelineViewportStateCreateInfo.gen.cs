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
    /// Structure specifying parameters of a newly created pipeline viewport
    /// state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineViewportStateCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineViewportStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of Viewport structures, defining the viewport transforms.
        /// If the viewport state is dynamic, this member is ignored.
        /// </summary>
        public SharpVk.Viewport[] Viewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of Rect2D structures which define the rectangular bounds
        /// of the scissor for the corresponding viewport. If the scissor state
        /// is dynamic, this member is ignored.
        /// </summary>
        public SharpVk.Rect2D[] Scissors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineViewportStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineViewportStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineViewportStateCreateFlags);
            }
            pointer->ViewportCount = (uint)(Interop.HeapUtil.GetLength(this.Viewports));
            if (this.Viewports != null)
            {
                var fieldPointer = (SharpVk.Viewport*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Viewport>(this.Viewports.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Viewports.Length); index++)
                {
                    fieldPointer[index] = this.Viewports[index];
                }
                pointer->Viewports = fieldPointer;
            }
            else
            {
                pointer->Viewports = null;
            }
            pointer->ScissorCount = (uint)(Interop.HeapUtil.GetLength(this.Scissors));
            if (this.Scissors != null)
            {
                var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(this.Scissors.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Scissors.Length); index++)
                {
                    fieldPointer[index] = this.Scissors[index];
                }
                pointer->Scissors = fieldPointer;
            }
            else
            {
                pointer->Scissors = null;
            }
        }
    }
}
