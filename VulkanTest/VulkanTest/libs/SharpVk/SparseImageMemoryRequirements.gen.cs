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
    /// Structure specifying sparse image memory requirements.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SparseImageMemoryRequirements
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseImageMemoryRequirements(SharpVk.SparseImageFormatProperties formatProperties, uint imageMipTailFirstLod, DeviceSize imageMipTailSize, DeviceSize imageMipTailOffset, DeviceSize imageMipTailStride)
        {
            this.FormatProperties = formatProperties;
            this.ImageMipTailFirstLod = imageMipTailFirstLod;
            this.ImageMipTailSize = imageMipTailSize;
            this.ImageMipTailOffset = imageMipTailOffset;
            this.ImageMipTailStride = imageMipTailStride;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SparseImageFormatProperties FormatProperties; 
        
        /// <summary>
        /// The first mip level at which image subresources are included in the
        /// mip tail region.
        /// </summary>
        public uint ImageMipTailFirstLod; 
        
        /// <summary>
        /// The memory size (in bytes) of the mip tail region. If
        /// formatProperties.flags contains
        /// VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT, this is the size of the
        /// whole mip tail, otherwise this is the size of the mip tail of a
        /// single array layer. This value is guaranteed to be a multiple of
        /// the sparse block size in bytes.
        /// </summary>
        public DeviceSize ImageMipTailSize; 
        
        /// <summary>
        /// The opaque memory offset used with SparseImageOpaqueMemoryBindInfo
        /// to bind the mip tail region(s).
        /// </summary>
        public DeviceSize ImageMipTailOffset; 
        
        /// <summary>
        /// The offset stride between each array-layer's mip tail, if
        /// formatProperties.flags does not contain
        /// VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT (otherwise the value is
        /// undefined).
        /// </summary>
        public DeviceSize ImageMipTailStride; 
    }
}
