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
    /// Structure specifying parameters of a newly created pipeline vertex
    /// input state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineVertexInputStateCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineVertexInputStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of VertexInputBindingDescription structures.
        /// </summary>
        public SharpVk.VertexInputBindingDescription[] VertexBindingDescriptions
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of VertexInputAttributeDescription structures.
        /// </summary>
        public SharpVk.VertexInputAttributeDescription[] VertexAttributeDescriptions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineVertexInputStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineVertexInputStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineVertexInputStateCreateFlags);
            }
            pointer->VertexBindingDescriptionCount = (uint)(Interop.HeapUtil.GetLength(this.VertexBindingDescriptions));
            if (this.VertexBindingDescriptions != null)
            {
                var fieldPointer = (SharpVk.VertexInputBindingDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.VertexInputBindingDescription>(this.VertexBindingDescriptions.Length).ToPointer());
                for(int index = 0; index < (uint)(this.VertexBindingDescriptions.Length); index++)
                {
                    fieldPointer[index] = this.VertexBindingDescriptions[index];
                }
                pointer->VertexBindingDescriptions = fieldPointer;
            }
            else
            {
                pointer->VertexBindingDescriptions = null;
            }
            pointer->VertexAttributeDescriptionCount = (uint)(Interop.HeapUtil.GetLength(this.VertexAttributeDescriptions));
            if (this.VertexAttributeDescriptions != null)
            {
                var fieldPointer = (SharpVk.VertexInputAttributeDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.VertexInputAttributeDescription>(this.VertexAttributeDescriptions.Length).ToPointer());
                for(int index = 0; index < (uint)(this.VertexAttributeDescriptions.Length); index++)
                {
                    fieldPointer[index] = this.VertexAttributeDescriptions[index];
                }
                pointer->VertexAttributeDescriptions = fieldPointer;
            }
            else
            {
                pointer->VertexAttributeDescriptions = null;
            }
        }
    }
}
