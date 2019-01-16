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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DescriptorUpdateTemplateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorUpdateTemplateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorUpdateTemplateEntry[] DescriptorUpdateEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorUpdateTemplateType TemplateType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DescriptorSetLayout DescriptorSetLayout
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
        public SharpVk.PipelineLayout PipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Set
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.DescriptorUpdateTemplateCreateInfo* pointer)
        {
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.DescriptorUpdateTemplateCreateFlags);
            }
            pointer->DescriptorUpdateEntryCount = (uint)(Interop.HeapUtil.GetLength(this.DescriptorUpdateEntries));
            if (this.DescriptorUpdateEntries != null)
            {
                var fieldPointer = (SharpVk.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.DescriptorUpdateTemplateEntry>(this.DescriptorUpdateEntries.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DescriptorUpdateEntries.Length); index++)
                {
                    fieldPointer[index] = this.DescriptorUpdateEntries[index];
                }
                pointer->DescriptorUpdateEntries = fieldPointer;
            }
            else
            {
                pointer->DescriptorUpdateEntries = null;
            }
            pointer->TemplateType = this.TemplateType;
            pointer->DescriptorSetLayout = this.DescriptorSetLayout?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->PipelineLayout = this.PipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            pointer->Set = this.Set;
        }
    }
}
