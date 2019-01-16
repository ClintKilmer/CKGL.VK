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

namespace SharpVk.Interop.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceMeshShaderProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawMeshTasksCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskWorkGroupInvocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint MaxTaskWorkGroupSize[3]; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskTotalMemorySize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskOutputCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshWorkGroupInvocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint MaxMeshWorkGroupSize[3]; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshTotalMemorySize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputVertices; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputPrimitives; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshMultiviewViewCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerVertexGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerPrimitiveGranularity; 
    }
}
