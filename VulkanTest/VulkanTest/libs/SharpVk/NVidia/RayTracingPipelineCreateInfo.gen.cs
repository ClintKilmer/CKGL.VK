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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct RayTracingPipelineCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.RayTracingShaderGroupCreateInfo[] Groups
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxRecursionDepth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.RayTracingPipelineCreateInfo* pointer)
        {
            pointer->SType = StructureType.RayTracingPipelineCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineCreateFlags);
            }
            pointer->StageCount = (uint)(Interop.HeapUtil.GetLength(this.Stages));
            if (this.Stages != null)
            {
                var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(this.Stages.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Stages.Length); index++)
                {
                    this.Stages[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Stages = fieldPointer;
            }
            else
            {
                pointer->Stages = null;
            }
            pointer->GroupCount = (uint)(Interop.HeapUtil.GetLength(this.Groups));
            if (this.Groups != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.RayTracingShaderGroupCreateInfo>(this.Groups.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Groups.Length); index++)
                {
                    this.Groups[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Groups = fieldPointer;
            }
            else
            {
                pointer->Groups = null;
            }
            pointer->MaxRecursionDepth = this.MaxRecursionDepth;
            pointer->Layout = this.Layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            pointer->BasePipelineHandle = this.BasePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
            pointer->BasePipelineIndex = this.BasePipelineIndex;
        }
    }
}
