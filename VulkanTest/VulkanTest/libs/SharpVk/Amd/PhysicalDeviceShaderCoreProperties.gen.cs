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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceShaderCoreProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ShaderEngineCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ShaderArraysPerEngineCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ComputeUnitsPerShaderArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SimdPerComputeUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint WavefrontsPerSimd
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint WavefrontSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SgprsPerSimd
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinSgprAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSgprAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SgprAllocationGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VgprsPerSimd
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinVgprAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVgprAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VgprAllocationGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceShaderCoreProperties MarshalFrom(SharpVk.Interop.Amd.PhysicalDeviceShaderCoreProperties* pointer)
        {
            PhysicalDeviceShaderCoreProperties result = default(PhysicalDeviceShaderCoreProperties);
            result.ShaderEngineCount = pointer->ShaderEngineCount;
            result.ShaderArraysPerEngineCount = pointer->ShaderArraysPerEngineCount;
            result.ComputeUnitsPerShaderArray = pointer->ComputeUnitsPerShaderArray;
            result.SimdPerComputeUnit = pointer->SimdPerComputeUnit;
            result.WavefrontsPerSimd = pointer->WavefrontsPerSimd;
            result.WavefrontSize = pointer->WavefrontSize;
            result.SgprsPerSimd = pointer->SgprsPerSimd;
            result.MinSgprAllocation = pointer->MinSgprAllocation;
            result.MaxSgprAllocation = pointer->MaxSgprAllocation;
            result.SgprAllocationGranularity = pointer->SgprAllocationGranularity;
            result.VgprsPerSimd = pointer->VgprsPerSimd;
            result.MinVgprAllocation = pointer->MinVgprAllocation;
            result.MaxVgprAllocation = pointer->MaxVgprAllocation;
            result.VgprAllocationGranularity = pointer->VgprAllocationGranularity;
            return result;
        }
    }
}
