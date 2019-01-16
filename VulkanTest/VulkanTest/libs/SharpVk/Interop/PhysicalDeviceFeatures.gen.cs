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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RobustBufferAccess; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FullDrawIndexUint32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ImageCubeArray; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IndependentBlend; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 GeometryShader; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TessellationShader; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SampleRateShading; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DualSourceBlend; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 LogicOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiDrawIndirect; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DrawIndirectFirstInstance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBiasClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FillModeNonSolid; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBounds; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 WideLines; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 LargePoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AlphaToOne; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiViewport; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SamplerAnisotropy; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TextureCompressionETC2; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TexturecompressionastcLdr; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TextureCompressionBC; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 OcclusionQueryPrecise; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PipelineStatisticsQuery; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 VertexPipelineStoresAndAtomics; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FragmentStoresAndAtomics; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderTessellationAndGeometryPointSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderImageGatherExtended; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageExtendedFormats; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageMultisample; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageReadWithoutFormat; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageWriteWithoutFormat; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSampledImageArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderClipDistance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderCullDistance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInt64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInt16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderResourceResidency; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderResourceMinLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyImage2D; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyImage3D; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency2Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency4Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency8Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency16Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyAliased; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 VariableMultisampleRate; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 InheritedQueries; 
    }
}
