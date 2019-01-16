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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Structure specifying the parameters of a newly created indirect
    /// commands layout object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// The PipelineBindPoint that this layout targets.
        /// </summary>
        public SharpVk.PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitmask providing usage hints of this layout. See
        /// IndirectCommandsLayoutUsageFlagBitsNVX below for a description of
        /// the supported bits.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayoutUsageFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array describing each command token in detail. See
        /// IndirectCommandsTokenTypeNVX and IndirectCommandsLayoutTokenNVX
        /// below for details.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken[] Tokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutCreateInfo;
            pointer->Next = null;
            pointer->PipelineBindPoint = this.PipelineBindPoint;
            pointer->Flags = this.Flags;
            pointer->TokenCount = (uint)(Interop.HeapUtil.GetLength(this.Tokens));
            if (this.Tokens != null)
            {
                var fieldPointer = (SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.IndirectCommandsLayoutToken>(this.Tokens.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Tokens.Length); index++)
                {
                    fieldPointer[index] = this.Tokens[index];
                }
                pointer->Tokens = fieldPointer;
            }
            else
            {
                pointer->Tokens = null;
            }
        }
    }
}
