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
    public partial struct PhysicalDeviceRayTracingProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ShaderGroupHandleSize
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
        public uint MaxShaderGroupStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ShaderGroupBaseAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxGeometryCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxInstanceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxTriangleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetAccelerationStructures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingProperties* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceRayTracingProperties;
            pointer->Next = null;
            pointer->ShaderGroupHandleSize = this.ShaderGroupHandleSize;
            pointer->MaxRecursionDepth = this.MaxRecursionDepth;
            pointer->MaxShaderGroupStride = this.MaxShaderGroupStride;
            pointer->ShaderGroupBaseAlignment = this.ShaderGroupBaseAlignment;
            pointer->MaxGeometryCount = this.MaxGeometryCount;
            pointer->MaxInstanceCount = this.MaxInstanceCount;
            pointer->MaxTriangleCount = this.MaxTriangleCount;
            pointer->MaxDescriptorSetAccelerationStructures = this.MaxDescriptorSetAccelerationStructures;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceRayTracingProperties MarshalFrom(SharpVk.Interop.NVidia.PhysicalDeviceRayTracingProperties* pointer)
        {
            PhysicalDeviceRayTracingProperties result = default(PhysicalDeviceRayTracingProperties);
            result.ShaderGroupHandleSize = pointer->ShaderGroupHandleSize;
            result.MaxRecursionDepth = pointer->MaxRecursionDepth;
            result.MaxShaderGroupStride = pointer->MaxShaderGroupStride;
            result.ShaderGroupBaseAlignment = pointer->ShaderGroupBaseAlignment;
            result.MaxGeometryCount = pointer->MaxGeometryCount;
            result.MaxInstanceCount = pointer->MaxInstanceCount;
            result.MaxTriangleCount = pointer->MaxTriangleCount;
            result.MaxDescriptorSetAccelerationStructures = pointer->MaxDescriptorSetAccelerationStructures;
            return result;
        }
    }
}
