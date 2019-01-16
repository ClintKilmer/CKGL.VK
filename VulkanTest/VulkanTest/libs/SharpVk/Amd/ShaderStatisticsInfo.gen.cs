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
    public partial struct ShaderStatisticsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags ShaderStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.ShaderResourceUsage ResourceUsage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumPhysicalVgprs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumPhysicalSgprs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumAvailableVgprs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumAvailableSgprs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) ComputeWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe ShaderStatisticsInfo MarshalFrom(SharpVk.Interop.Amd.ShaderStatisticsInfo* pointer)
        {
            ShaderStatisticsInfo result = default(ShaderStatisticsInfo);
            result.ShaderStageMask = pointer->ShaderStageMask;
            result.ResourceUsage = pointer->ResourceUsage;
            result.NumPhysicalVgprs = pointer->NumPhysicalVgprs;
            result.NumPhysicalSgprs = pointer->NumPhysicalSgprs;
            result.NumAvailableVgprs = pointer->NumAvailableVgprs;
            result.NumAvailableSgprs = pointer->NumAvailableSgprs;
            result.ComputeWorkGroupSize = (pointer->ComputeWorkGroupSize[0], pointer->ComputeWorkGroupSize[1], pointer->ComputeWorkGroupSize[2]);
            return result;
        }
    }
}
