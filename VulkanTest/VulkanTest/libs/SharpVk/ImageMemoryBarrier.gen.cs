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
    /// Structure specifying the parameters of an image memory barrier.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageMemoryBarrier
    {
        /// <summary>
        /// Defines a source access mask.
        /// </summary>
        public SharpVk.AccessFlags? SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// Defines a destination access mask.
        /// </summary>
        public SharpVk.AccessFlags? DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// The old layout in an image layout transition.
        /// </summary>
        public SharpVk.ImageLayout OldLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// The new layout in an image layout transition.
        /// </summary>
        public SharpVk.ImageLayout NewLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// The source queue family for a queue family ownership transfer.
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// The destination queue family for a queue family ownership transfer.
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// A handle to the image affected by this barrier.
        /// </summary>
        public SharpVk.Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// Describes the image subresource range within image that is affected
        /// by this barrier.
        /// </summary>
        public SharpVk.ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.ImageMemoryBarrier* pointer)
        {
            pointer->SType = StructureType.ImageMemoryBarrier;
            pointer->Next = null;
            if (this.SourceAccessMask != null)
            {
                pointer->SourceAccessMask = this.SourceAccessMask.Value;
            }
            else
            {
                pointer->SourceAccessMask = default(SharpVk.AccessFlags);
            }
            if (this.DestinationAccessMask != null)
            {
                pointer->DestinationAccessMask = this.DestinationAccessMask.Value;
            }
            else
            {
                pointer->DestinationAccessMask = default(SharpVk.AccessFlags);
            }
            pointer->OldLayout = this.OldLayout;
            pointer->NewLayout = this.NewLayout;
            pointer->SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
            pointer->DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
            pointer->Image = this.Image?.handle ?? default(SharpVk.Interop.Image);
            pointer->SubresourceRange = this.SubresourceRange;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe ImageMemoryBarrier MarshalFrom(SharpVk.Interop.ImageMemoryBarrier* pointer)
        {
            ImageMemoryBarrier result = default(ImageMemoryBarrier);
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            result.OldLayout = pointer->OldLayout;
            result.NewLayout = pointer->NewLayout;
            result.SourceQueueFamilyIndex = pointer->SourceQueueFamilyIndex;
            result.DestinationQueueFamilyIndex = pointer->DestinationQueueFamilyIndex;
            result.Image = new SharpVk.Image(default(SharpVk.Device), pointer->Image);
            result.SubresourceRange = pointer->SubresourceRange;
            return result;
        }
    }
}
