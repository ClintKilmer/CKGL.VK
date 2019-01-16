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
    /// Structure specifying the parameters of a newly created pipeline layout
    /// object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineLayoutCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineLayoutCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of DescriptorSetLayout objects.
        /// </summary>
        public SharpVk.DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of PushConstantRange structures defining a set of push
        /// constant ranges for use in a single pipeline layout. In addition to
        /// descriptor set layouts, a pipeline layout also describes how many
        /// push constants can be accessed by each stage of the pipeline. +
        /// [NOTE] .Note ==== Push constants represent a high speed path to
        /// modify constant data in pipelines that is expected to outperform
        /// memory-backed resource updates. ====
        /// </summary>
        public SharpVk.PushConstantRange[] PushConstantRanges
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineLayoutCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineLayoutCreateFlags);
            }
            pointer->SetLayoutCount = (uint)(Interop.HeapUtil.GetLength(this.SetLayouts));
            if (this.SetLayouts != null)
            {
                var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(this.SetLayouts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SetLayouts.Length); index++)
                {
                    fieldPointer[index] = this.SetLayouts[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                }
                pointer->SetLayouts = fieldPointer;
            }
            else
            {
                pointer->SetLayouts = null;
            }
            pointer->PushConstantRangeCount = (uint)(Interop.HeapUtil.GetLength(this.PushConstantRanges));
            if (this.PushConstantRanges != null)
            {
                var fieldPointer = (SharpVk.PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PushConstantRange>(this.PushConstantRanges.Length).ToPointer());
                for(int index = 0; index < (uint)(this.PushConstantRanges.Length); index++)
                {
                    fieldPointer[index] = this.PushConstantRanges[index];
                }
                pointer->PushConstantRanges = fieldPointer;
            }
            else
            {
                pointer->PushConstantRanges = null;
            }
        }
    }
}
