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
    /// Structure specifying a draw indexed indirect command.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DrawIndexedIndirectCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public static DrawIndexedIndirectCommand Zero => new DrawIndexedIndirectCommand();
        
        /// <summary>
        /// 
        /// </summary>
        public DrawIndexedIndirectCommand(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            this.IndexCount = indexCount;
            this.InstanceCount = instanceCount;
            this.FirstIndex = firstIndex;
            this.VertexOffset = vertexOffset;
            this.FirstInstance = firstInstance;
        }
        
        /// <summary>
        /// The number of vertices to draw.
        /// </summary>
        public uint IndexCount; 
        
        /// <summary>
        /// The number of instances to draw.
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// The base index within the index buffer.
        /// </summary>
        public uint FirstIndex; 
        
        /// <summary>
        /// The value added to the vertex index before indexing into the vertex
        /// buffer.
        /// </summary>
        public int VertexOffset; 
        
        /// <summary>
        /// The instance ID of the first instance to draw.
        /// </summary>
        public uint FirstInstance; 
    }
}
