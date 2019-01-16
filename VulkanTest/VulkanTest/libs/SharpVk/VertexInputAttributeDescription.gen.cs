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
    /// Structure specifying vertex input attribute description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VertexInputAttributeDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public VertexInputAttributeDescription(uint location, uint binding, SharpVk.Format format, uint offset)
        {
            this.Location = location;
            this.Binding = binding;
            this.Format = format;
            this.Offset = offset;
        }
        
        /// <summary>
        /// The shader binding location number for this attribute.
        /// </summary>
        public uint Location; 
        
        /// <summary>
        /// The binding number which this attribute takes its data from.
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// The size and type of the vertex attribute data.
        /// </summary>
        public SharpVk.Format Format; 
        
        /// <summary>
        /// A byte offset of this attribute relative to the start of an element
        /// in the vertex input binding.
        /// </summary>
        public uint Offset; 
    }
}
