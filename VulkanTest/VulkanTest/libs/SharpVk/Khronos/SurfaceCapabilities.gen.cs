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
    /// Structure describing capabilities of a surface.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfaceCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SurfaceCapabilities(uint minImageCount, uint maxImageCount, SharpVk.Extent2D currentExtent, SharpVk.Extent2D minImageExtent, SharpVk.Extent2D maxImageExtent, uint maxImageArrayLayers, SharpVk.Khronos.SurfaceTransformFlags supportedTransforms, SharpVk.Khronos.SurfaceTransformFlags currentTransform, SharpVk.Khronos.CompositeAlphaFlags supportedCompositeAlpha, SharpVk.ImageUsageFlags supportedUsageFlags)
        {
            this.MinImageCount = minImageCount;
            this.MaxImageCount = maxImageCount;
            this.CurrentExtent = currentExtent;
            this.MinImageExtent = minImageExtent;
            this.MaxImageExtent = maxImageExtent;
            this.MaxImageArrayLayers = maxImageArrayLayers;
            this.SupportedTransforms = supportedTransforms;
            this.CurrentTransform = currentTransform;
            this.SupportedCompositeAlpha = supportedCompositeAlpha;
            this.SupportedUsageFlags = supportedUsageFlags;
        }
        
        /// <summary>
        /// The minimum number of images the specified device supports for a
        /// swapchain created for the surface, and will be at least one.
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// The maximum number of images the specified device supports for a
        /// swapchain created for the surface, and will be either 0, or greater
        /// than or equal to minImageCount. A value of 0 means that there is no
        /// limit on the number of images, though there may be limits related
        /// to the total amount of memory used by presentable images.
        /// </summary>
        public uint MaxImageCount; 
        
        /// <summary>
        /// The current width and height of the surface, or the special value
        /// [eq]#(0xFFFFFFFF, 0xFFFFFFFF)# indicating that the surface size
        /// will be determined by the extent of a swapchain targeting the
        /// surface.
        /// </summary>
        public SharpVk.Extent2D CurrentExtent; 
        
        /// <summary>
        /// minImageExtent contains the smallest valid swapchain extent for the
        /// surface on the specified device. The width and height of the extent
        /// will each be less than or equal to the corresponding width and
        /// height of currentExtent, unless currentExtent has the special value
        /// described above.
        /// </summary>
        public SharpVk.Extent2D MinImageExtent; 
        
        /// <summary>
        /// maxImageExtent contains the largest valid swapchain extent for the
        /// surface on the specified device. The width and height of the extent
        /// will each be greater than or equal to the corresponding width and
        /// height of minImageExtent. The width and height of the extent will
        /// each be greater than or equal to the corresponding width and height
        /// of currentExtent, unless currentExtent has the special value
        /// described above.
        /// </summary>
        public SharpVk.Extent2D MaxImageExtent; 
        
        /// <summary>
        /// The maximum number of layers presentable images can have for a
        /// swapchain created for this device and surface, and will be at least
        /// one.
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// A bitmask of SurfaceTransformFlagBitsKHR, describing the
        /// presentation transforms supported for the surface on the specified
        /// device, and at least one bit will be set.
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// The surface's current transform relative to the presentation
        /// engine's natural orientation, as described by
        /// SurfaceTransformFlagBitsKHR.
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags CurrentTransform; 
        
        /// <summary>
        /// A bitmask of CompositeAlphaFlagBitsKHR, representing the alpha
        /// compositing modes supported by the presentation engine for the
        /// surface on the specified device, and at least one bit will be set.
        /// Opaque composition can be achieved in any alpha compositing mode by
        /// either using an image format that has no alpha component, or by
        /// ensuring that all pixels in the presentable images have an alpha
        /// value of 1.0.
        /// </summary>
        public SharpVk.Khronos.CompositeAlphaFlags SupportedCompositeAlpha; 
        
        /// <summary>
        /// A bitmask of ImageUsageFlagBits representing the ways the
        /// application can use the presentable images of a swapchain created
        /// for the surface on the specified device.
        /// VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must be included in the set but
        /// implementations may support additional usages.
        /// </summary>
        public SharpVk.ImageUsageFlags SupportedUsageFlags; 
    }
}
