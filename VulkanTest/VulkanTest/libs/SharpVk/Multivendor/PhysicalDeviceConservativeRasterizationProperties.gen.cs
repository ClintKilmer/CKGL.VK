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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceConservativeRasterizationProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public float PrimitiveOverestimationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxExtraPrimitiveOverestimationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float ExtraPrimitiveOverestimationSizeGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrimitiveUnderestimation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ConservativePointAndLineRasterization
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DegenerateTrianglesRasterized
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool DegenerateLinesRasterized
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FullyCoveredFragmentShaderInputVariable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ConservativeRasterizationPostDepthCoverage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceConservativeRasterizationProperties* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceConservativeRasterizationProperties;
            pointer->Next = null;
            pointer->PrimitiveOverestimationSize = this.PrimitiveOverestimationSize;
            pointer->MaxExtraPrimitiveOverestimationSize = this.MaxExtraPrimitiveOverestimationSize;
            pointer->ExtraPrimitiveOverestimationSizeGranularity = this.ExtraPrimitiveOverestimationSizeGranularity;
            pointer->PrimitiveUnderestimation = this.PrimitiveUnderestimation;
            pointer->ConservativePointAndLineRasterization = this.ConservativePointAndLineRasterization;
            pointer->DegenerateTrianglesRasterized = this.DegenerateTrianglesRasterized;
            pointer->DegenerateLinesRasterized = this.DegenerateLinesRasterized;
            pointer->FullyCoveredFragmentShaderInputVariable = this.FullyCoveredFragmentShaderInputVariable;
            pointer->ConservativeRasterizationPostDepthCoverage = this.ConservativeRasterizationPostDepthCoverage;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceConservativeRasterizationProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceConservativeRasterizationProperties* pointer)
        {
            PhysicalDeviceConservativeRasterizationProperties result = default(PhysicalDeviceConservativeRasterizationProperties);
            result.PrimitiveOverestimationSize = pointer->PrimitiveOverestimationSize;
            result.MaxExtraPrimitiveOverestimationSize = pointer->MaxExtraPrimitiveOverestimationSize;
            result.ExtraPrimitiveOverestimationSizeGranularity = pointer->ExtraPrimitiveOverestimationSizeGranularity;
            result.PrimitiveUnderestimation = pointer->PrimitiveUnderestimation;
            result.ConservativePointAndLineRasterization = pointer->ConservativePointAndLineRasterization;
            result.DegenerateTrianglesRasterized = pointer->DegenerateTrianglesRasterized;
            result.DegenerateLinesRasterized = pointer->DegenerateLinesRasterized;
            result.FullyCoveredFragmentShaderInputVariable = pointer->FullyCoveredFragmentShaderInputVariable;
            result.ConservativeRasterizationPostDepthCoverage = pointer->ConservativeRasterizationPostDepthCoverage;
            return result;
        }
    }
}
