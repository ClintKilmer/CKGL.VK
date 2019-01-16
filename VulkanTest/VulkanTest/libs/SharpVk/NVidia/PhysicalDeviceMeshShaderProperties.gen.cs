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
    public partial struct PhysicalDeviceMeshShaderProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawMeshTasksCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxTaskWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskTotalMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTaskOutputCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) MaxMeshWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshTotalMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshOutputPrimitives
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMeshMultiviewViewCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerVertexGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MeshOutputPerPrimitiveGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderProperties* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceMeshShaderProperties;
            pointer->Next = null;
            pointer->MaxDrawMeshTasksCount = this.MaxDrawMeshTasksCount;
            pointer->MaxTaskWorkGroupInvocations = this.MaxTaskWorkGroupInvocations;
            pointer->MaxTaskWorkGroupSize[0] = this.MaxTaskWorkGroupSize.Item1;
            pointer->MaxTaskWorkGroupSize[1] = this.MaxTaskWorkGroupSize.Item2;
            pointer->MaxTaskWorkGroupSize[2] = this.MaxTaskWorkGroupSize.Item3;
            pointer->MaxTaskTotalMemorySize = this.MaxTaskTotalMemorySize;
            pointer->MaxTaskOutputCount = this.MaxTaskOutputCount;
            pointer->MaxMeshWorkGroupInvocations = this.MaxMeshWorkGroupInvocations;
            pointer->MaxMeshWorkGroupSize[0] = this.MaxMeshWorkGroupSize.Item1;
            pointer->MaxMeshWorkGroupSize[1] = this.MaxMeshWorkGroupSize.Item2;
            pointer->MaxMeshWorkGroupSize[2] = this.MaxMeshWorkGroupSize.Item3;
            pointer->MaxMeshTotalMemorySize = this.MaxMeshTotalMemorySize;
            pointer->MaxMeshOutputVertices = this.MaxMeshOutputVertices;
            pointer->MaxMeshOutputPrimitives = this.MaxMeshOutputPrimitives;
            pointer->MaxMeshMultiviewViewCount = this.MaxMeshMultiviewViewCount;
            pointer->MeshOutputPerVertexGranularity = this.MeshOutputPerVertexGranularity;
            pointer->MeshOutputPerPrimitiveGranularity = this.MeshOutputPerPrimitiveGranularity;
        }
    }
}
