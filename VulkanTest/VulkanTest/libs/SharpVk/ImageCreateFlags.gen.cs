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
    /// Bitmask specifying additional parameters of an image.
    /// </summary>
    [System.Flags]
    public enum ImageCreateFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Indicates that the image will be backed using sparse memory
        /// binding.
        /// </summary>
        SparseBinding = 1 << 0, 
        
        /// <summary>
        /// Indicates that the image can be partially backed using sparse
        /// memory binding. Images created with this flag must also be created
        /// with the VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag.
        /// </summary>
        SparseResidency = 1 << 1, 
        
        /// <summary>
        /// Indicates that the image will be backed using sparse memory binding
        /// with memory ranges that might also simultaneously be backing
        /// another image (or another portion of the same image). Images
        /// created with this flag must also be created with the
        /// VK_IMAGE_CREATE_SPARSE_BINDING_BIT flag
        /// </summary>
        SparseAliased = 1 << 2, 
        
        /// <summary>
        /// Indicates that the image can be used to create an ImageView with a
        /// different format from the image.
        /// </summary>
        MutableFormat = 1 << 3, 
        
        /// <summary>
        /// Indicates that the image can be used to create an ImageView of type
        /// VK_IMAGE_VIEW_TYPE_CUBE or VK_IMAGE_VIEW_TYPE_CUBE_ARRAY.
        /// </summary>
        CubeCompatible = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        CornerSampled = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleLocationsCompatibleDepth = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        Subsampled = 1 << 14, 
    }
}
