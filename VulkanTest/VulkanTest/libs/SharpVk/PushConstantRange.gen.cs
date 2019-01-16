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
    /// Structure specifying a push constant range.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PushConstantRange
    {
        /// <summary>
        /// 
        /// </summary>
        public PushConstantRange(SharpVk.ShaderStageFlags stageFlags, uint offset, uint size)
        {
            this.StageFlags = stageFlags;
            this.Offset = offset;
            this.Size = size;
        }
        
        /// <summary>
        /// A set of stage flags describing the shader stages that will access
        /// a range of push constants. If a particular stage is not included in
        /// the range, then accessing members of that range of push constants
        /// from the corresponding shader stage will result in undefined data
        /// being read.
        /// </summary>
        public SharpVk.ShaderStageFlags StageFlags; 
        
        /// <summary>
        /// offset and size are the start offset and size, respectively,
        /// consumed by the range. Both offset and size are in units of bytes
        /// and must be a multiple of 4. The layout of the push constant
        /// variables is specified in the shader.
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Size; 
    }
}
