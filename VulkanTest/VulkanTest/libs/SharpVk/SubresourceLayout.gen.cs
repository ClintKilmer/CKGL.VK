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
    /// Structure specifying subresource layout.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubresourceLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public SubresourceLayout(DeviceSize offset, DeviceSize size, DeviceSize rowPitch, DeviceSize arrayPitch, DeviceSize depthPitch)
        {
            this.Offset = offset;
            this.Size = size;
            this.RowPitch = rowPitch;
            this.ArrayPitch = arrayPitch;
            this.DepthPitch = depthPitch;
        }
        
        /// <summary>
        /// The byte offset from the start of the image where the image
        /// subresource begins.
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// The size in bytes of the image subresource. size includes any extra
        /// memory that is required based on rowPitch.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// rowPitch describes the number of bytes between each row of texels
        /// in an image.
        /// </summary>
        public DeviceSize RowPitch; 
        
        /// <summary>
        /// arrayPitch describes the number of bytes between each array layer
        /// of an image.
        /// </summary>
        public DeviceSize ArrayPitch; 
        
        /// <summary>
        /// depthPitch describes the number of bytes between each slice of 3D
        /// image.
        /// </summary>
        public DeviceSize DepthPitch; 
    }
}
