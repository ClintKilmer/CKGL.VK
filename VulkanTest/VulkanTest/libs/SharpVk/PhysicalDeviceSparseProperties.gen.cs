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
    /// Structure specifying physical device sparse memory properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceSparseProperties
    {
        /// <summary>
        /// residencyStandard2DBlockShape is VK_TRUE if the physical device
        /// will access all single-sample 2D sparse resources using the
        /// standard sparse image block shapes (based on image format), as
        /// described in the Standard Sparse Image Block Shapes (Single Sample)
        /// table. If this property is not supported the value returned in the
        /// imageGranularity member of the SparseImageFormatProperties
        /// structure for single-sample 2D images is not required: to match the
        /// standard sparse image block dimensions listed in the table.
        /// </summary>
        public bool ResidencyStandard2DBlockShape
        {
            get;
            set;
        }
        
        /// <summary>
        /// residencyStandard2DMultisampleBlockShape is VK_TRUE if the physical
        /// device will access all multisample 2D sparse resources using the
        /// standard sparse image block shapes (based on image format), as
        /// described in the Standard Sparse Image Block Shapes (MSAA) table.
        /// If this property is not supported, the value returned in the
        /// imageGranularity member of the SparseImageFormatProperties
        /// structure for multisample 2D images is not required: to match the
        /// standard sparse image block dimensions listed in the table.
        /// </summary>
        public bool ResidencyStandard2DMultisampleBlockShape
        {
            get;
            set;
        }
        
        /// <summary>
        /// residencyStandard3DBlockShape is VK_TRUE if the physical device
        /// will access all 3D sparse resources using the standard sparse image
        /// block shapes (based on image format), as described in the Standard
        /// Sparse Image Block Shapes (Single Sample) table. If this property
        /// is not supported, the value returned in the imageGranularity member
        /// of the SparseImageFormatProperties structure for 3D images is not
        /// required: to match the standard sparse image block dimensions
        /// listed in the table.
        /// </summary>
        public bool ResidencyStandard3DBlockShape
        {
            get;
            set;
        }
        
        /// <summary>
        /// residencyAlignedMipSize is VK_TRUE if images with mip level
        /// dimensions that are not integer multiples of the corresponding
        /// dimensions of the sparse image block may be placed in the mip tail.
        /// If this property is not reported, only mip levels with dimensions
        /// smaller than the imageGranularity member of the
        /// SparseImageFormatProperties structure will be placed in the mip
        /// tail. If this property is reported the implementation is allowed to
        /// return VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT in the flags
        /// member of SparseImageFormatProperties, indicating that mip level
        /// dimensions that are not integer multiples of the corresponding
        /// dimensions of the sparse image block will be placed in the mip
        /// tail.
        /// </summary>
        public bool ResidencyAlignedMipSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies whether the physical device can consistently access
        /// non-resident regions of a resource. If this property is VK_TRUE,
        /// access to non-resident regions of resources will be guaranteed to
        /// return values as if the resource were populated with 0; writes to
        /// non-resident regions will be discarded.
        /// </summary>
        public bool ResidencyNonResidentStrict
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceSparseProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceSparseProperties* pointer)
        {
            PhysicalDeviceSparseProperties result = default(PhysicalDeviceSparseProperties);
            result.ResidencyStandard2DBlockShape = pointer->ResidencyStandard2DBlockShape;
            result.ResidencyStandard2DMultisampleBlockShape = pointer->ResidencyStandard2DMultisampleBlockShape;
            result.ResidencyStandard3DBlockShape = pointer->ResidencyStandard3DBlockShape;
            result.ResidencyAlignedMipSize = pointer->ResidencyAlignedMipSize;
            result.ResidencyNonResidentStrict = pointer->ResidencyNonResidentStrict;
            return result;
        }
    }
}
