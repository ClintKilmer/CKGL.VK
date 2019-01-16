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

namespace SharpVk
{
    /// <summary>
    /// Bitmask specifying features supported by a buffer.
    /// </summary>
    [System.Flags]
    public enum FormatFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImage = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImage = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageAtomic = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBufferAtomic = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachment = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentBlend = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachment = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitSource = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        BlitDestination = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterLinear = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterCubic = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved27 = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved28 = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved25 = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved26 = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageFilterMinmax = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityMap = 1 << 24, 
    }
}
