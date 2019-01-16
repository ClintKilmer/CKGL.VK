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
    /// Structure specifying a image format properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageFormatProperties(SharpVk.Extent3D maxExtent, uint maxMipLevels, uint maxArrayLayers, SharpVk.SampleCountFlags sampleCounts, DeviceSize maxResourceSize)
        {
            this.MaxExtent = maxExtent;
            this.MaxMipLevels = maxMipLevels;
            this.MaxArrayLayers = maxArrayLayers;
            this.SampleCounts = sampleCounts;
            this.MaxResourceSize = maxResourceSize;
        }
        
        /// <summary>
        /// maxExtent are the maximum image dimensions. See the Allowed Extent
        /// Values section below for how these values are constrained by type.
        /// </summary>
        public SharpVk.Extent3D MaxExtent; 
        
        /// <summary>
        /// The maximum number of mipmap levels. maxMipLevels must either be
        /// equal to 1 (valid only if tiling is ImageTiling.Linear) or be equal
        /// to [eq]#{lceil}log~2~(max(width, height, depth)){rceil} {plus} 1#.
        /// [eq]#width#, [eq]#height#, and [eq]#depth# are taken from the
        /// corresponding members of maxExtent.
        /// </summary>
        public uint MaxMipLevels; 
        
        /// <summary>
        /// The maximum number of array layers. maxArrayLayers must either be
        /// equal to 1 or be greater than or equal to the maxImageArrayLayers
        /// member of PhysicalDeviceLimits. A value of 1 is valid only if
        /// tiling is ImageTiling.Linear or if type is VK_IMAGE_TYPE_3D.
        /// </summary>
        public uint MaxArrayLayers; 
        
        /// <summary>
        /// A bitmask of SampleCountFlagBits specifying all the supported
        /// sample counts for this image as described below.
        /// </summary>
        public SharpVk.SampleCountFlags SampleCounts; 
        
        /// <summary>
        /// An upper bound on the total image size in bytes, inclusive of all
        /// image subresources. Implementations may have an address space limit
        /// on total size of a resource, which is advertised by this property.
        /// maxResourceSize must be at least 2^31^.
        /// </summary>
        public DeviceSize MaxResourceSize; 
    }
}
