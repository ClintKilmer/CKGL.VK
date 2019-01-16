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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Alpha compositing modes supported on a device.
    /// </summary>
    [System.Flags]
    public enum CompositeAlphaFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// The alpha channel, if it exists, of the images is ignored in the
        /// compositing process. Instead, the image is treated as if it has a
        /// constant alpha of 1.0.
        /// </summary>
        Opaque = 1 << 0, 
        
        /// <summary>
        /// The alpha channel, if it exists, of the images is respected in the
        /// compositing process. The non-alpha channels of the image are
        /// expected to already be multiplied by the alpha channel by the
        /// application.
        /// </summary>
        PreMultiplied = 1 << 1, 
        
        /// <summary>
        /// The alpha channel, if it exists, of the images is respected in the
        /// compositing process. The non-alpha channels of the image are not
        /// expected to already be multiplied by the alpha channel by the
        /// application; instead, the compositor will multiply the non-alpha
        /// channels of the image by the alpha channel during compositing.
        /// </summary>
        PostMultiplied = 1 << 2, 
        
        /// <summary>
        /// The way in which the presentation engine treats the alpha channel
        /// in the images is unknown to the Vulkan API. Instead, the
        /// application is responsible for setting the composite alpha blending
        /// mode using native window system commands. If the application does
        /// not set the blending mode using native window system commands, then
        /// a platform-specific default will be used.
        /// </summary>
        Inherit = 1 << 3, 
    }
}
