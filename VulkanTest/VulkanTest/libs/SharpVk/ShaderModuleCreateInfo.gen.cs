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
    /// Structure specifying parameters of a newly created shader module.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ShaderModuleCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.ShaderModuleCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// The size, in bytes, of the code.
        /// </summary>
        public HostSize CodeSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// Points to code that is used to create the shader module. The type
        /// and format of the code is determined from the content of the memory
        /// addressed.
        /// </summary>
        public uint[] Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.ShaderModuleCreateInfo* pointer)
        {
            pointer->SType = StructureType.ShaderModuleCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.ShaderModuleCreateFlags);
            }
            pointer->CodeSize = this.CodeSize;
            if (this.Code != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.Code.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Code.Length); index++)
                {
                    fieldPointer[index] = this.Code[index];
                }
                pointer->Code = fieldPointer;
            }
            else
            {
                pointer->Code = null;
            }
        }
    }
}
