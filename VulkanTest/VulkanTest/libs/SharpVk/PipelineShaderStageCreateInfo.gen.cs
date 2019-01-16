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
    /// Structure specifying parameters of a newly created pipeline shader
    /// stage.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineShaderStageCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineShaderStageCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// stage names a single pipeline stage. Bits which can be set include:
        /// + --
        /// </summary>
        public SharpVk.ShaderStageFlags Stage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderModule Module
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SpecializationInfo? SpecializationInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineShaderStageCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineShaderStageCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineShaderStageCreateFlags);
            }
            pointer->Stage = this.Stage;
            pointer->Module = this.Module?.handle ?? default(SharpVk.Interop.ShaderModule);
            pointer->Name = Interop.HeapUtil.MarshalTo(this.Name);
            if (this.SpecializationInfo != null)
            {
                pointer->SpecializationInfo = (SharpVk.Interop.SpecializationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SpecializationInfo>());
                this.SpecializationInfo.Value.MarshalTo(pointer->SpecializationInfo);
            }
            else
            {
                pointer->SpecializationInfo = default(SharpVk.Interop.SpecializationInfo*);
            }
        }
    }
}
