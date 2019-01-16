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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Structure specifying parameters of a newly created swapchain object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SwapchainCreateInfo
    {
        /// <summary>
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </summary>
        public SharpVk.Khronos.SwapchainCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.Surface Surface
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinImageCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format ImageFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ColorSpace ImageColorSpace
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D ImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageUsageFlags ImageUsage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SharingMode ImageSharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags PreTransform
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.CompositeAlphaFlags CompositeAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PresentMode PresentMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Clipped
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.Swapchain OldSwapchain
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.SwapchainCreateInfo* pointer)
        {
            pointer->SType = StructureType.SwapchainCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
            }
            pointer->Surface = this.Surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
            pointer->MinImageCount = this.MinImageCount;
            pointer->ImageFormat = this.ImageFormat;
            pointer->ImageColorSpace = this.ImageColorSpace;
            pointer->ImageExtent = this.ImageExtent;
            pointer->ImageArrayLayers = this.ImageArrayLayers;
            pointer->ImageUsage = this.ImageUsage;
            pointer->ImageSharingMode = this.ImageSharingMode;
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
            pointer->PreTransform = this.PreTransform;
            pointer->CompositeAlpha = this.CompositeAlpha;
            pointer->PresentMode = this.PresentMode;
            pointer->Clipped = this.Clipped;
            pointer->OldSwapchain = this.OldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
        }
    }
}
