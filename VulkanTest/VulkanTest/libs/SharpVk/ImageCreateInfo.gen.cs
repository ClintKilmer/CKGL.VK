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
    /// Structure specifying the parameters of a newly created image object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageCreateInfo
    {
        /// <summary>
        /// A bitmask describing additional parameters of the image. See
        /// ImageCreateFlagBits below for a description of the supported bits.
        /// </summary>
        public SharpVk.ImageCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// An ImageType specifying the basic dimensionality of the image, as
        /// described below. Layers in array textures do not count as a
        /// dimension for the purposes of the image type.
        /// </summary>
        public SharpVk.ImageType ImageType
        {
            get;
            set;
        }
        
        /// <summary>
        /// A Format describing the format and type of the data elements that
        /// will be contained in the image.
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// A Extent3D describing the number of data elements in each dimension
        /// of the base level.
        /// </summary>
        public SharpVk.Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// mipLevels describes the number of levels of detail available for
        /// minified sampling of the image.
        /// </summary>
        public uint MipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of layers in the image.
        /// </summary>
        public uint ArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// The number of sub-data element samples in the image as defined in
        /// SampleCountFlagBits. See Multisampling.
        /// </summary>
        public SharpVk.SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// An ImageTiling specifying the tiling arrangement of the data
        /// elements in memory, as described below.
        /// </summary>
        public SharpVk.ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// A bitmask describing the intended usage of the image. See
        /// ImageUsageFlagBits below for a description of the supported bits.
        /// </summary>
        public SharpVk.ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The sharing mode of the image when it will be accessed by multiple
        /// queue families, and must be one of the values described for
        /// SharingMode in the Resource Sharing section below.
        /// </summary>
        public SharpVk.SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// A list of queue families that will access this image (ignored if
        /// sharingMode is not VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// initialLayout selects the initial ImageLayout state of all image
        /// subresources of the image. See Image Layouts. initialLayout must be
        /// VK_IMAGE_LAYOUT_UNDEFINED or VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </summary>
        public SharpVk.ImageLayout InitialLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.ImageCreateInfo* pointer)
        {
            pointer->SType = StructureType.ImageCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.ImageCreateFlags);
            }
            pointer->ImageType = this.ImageType;
            pointer->Format = this.Format;
            pointer->Extent = this.Extent;
            pointer->MipLevels = this.MipLevels;
            pointer->ArrayLayers = this.ArrayLayers;
            pointer->Samples = this.Samples;
            pointer->Tiling = this.Tiling;
            pointer->Usage = this.Usage;
            pointer->SharingMode = this.SharingMode;
            pointer->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(this.QueueFamilyIndices));
            if (this.QueueFamilyIndices != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.QueueFamilyIndices.Length).ToPointer());
                for(int index = 0; index < (uint)(this.QueueFamilyIndices.Length); index++)
                {
                    fieldPointer[index] = this.QueueFamilyIndices[index];
                }
                pointer->QueueFamilyIndices = fieldPointer;
            }
            else
            {
                pointer->QueueFamilyIndices = null;
            }
            pointer->InitialLayout = this.InitialLayout;
        }
    }
}
