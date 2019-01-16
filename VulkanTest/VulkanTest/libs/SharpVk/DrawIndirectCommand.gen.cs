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
    /// Structure specifying a draw indirect command.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DrawIndirectCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public static DrawIndirectCommand Zero => new DrawIndirectCommand();
        
        /// <summary>
        /// 
        /// </summary>
        public DrawIndirectCommand(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            this.VertexCount = vertexCount;
            this.InstanceCount = instanceCount;
            this.FirstVertex = firstVertex;
            this.FirstInstance = firstInstance;
        }
        
        /// <summary>
        /// The number of vertices to draw.
        /// </summary>
        public uint VertexCount; 
        
        /// <summary>
        /// The number of instances to draw.
        /// </summary>
        public uint InstanceCount; 
        
        /// <summary>
        /// The index of the first vertex to draw.
        /// </summary>
        public uint FirstVertex; 
        
        /// <summary>
        /// The instance ID of the first instance to draw.
        /// </summary>
        public uint FirstInstance; 
    }
}
