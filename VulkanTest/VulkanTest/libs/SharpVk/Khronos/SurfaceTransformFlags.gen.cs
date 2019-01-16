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
    /// Presentation transforms supported on a device.
    /// </summary>
    [System.Flags]
    public enum SurfaceTransformFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// The image content is presented without being transformed.
        /// </summary>
        Identity = 1 << 0, 
        
        /// <summary>
        /// The image content is rotated 90 degrees clockwise.
        /// </summary>
        Rotate90 = 1 << 1, 
        
        /// <summary>
        /// The image content is rotated 180 degrees clockwise.
        /// </summary>
        Rotate180 = 1 << 2, 
        
        /// <summary>
        /// The image content is rotated 270 degrees clockwise.
        /// </summary>
        Rotate270 = 1 << 3, 
        
        /// <summary>
        /// The image content is mirrored horizontally.
        /// </summary>
        HorizontalMirror = 1 << 4, 
        
        /// <summary>
        /// The image content is mirrored horizontally, then rotated 90 degrees
        /// clockwise.
        /// </summary>
        HorizontalMirrorRotate90 = 1 << 5, 
        
        /// <summary>
        /// The image content is mirrored horizontally, then rotated 180
        /// degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate180 = 1 << 6, 
        
        /// <summary>
        /// The image content is mirrored horizontally, then rotated 270
        /// degrees clockwise.
        /// </summary>
        HorizontalMirrorRotate270 = 1 << 7, 
        
        /// <summary>
        /// The presentation transform is not specified, and is instead
        /// determined by platform-specific considerations and mechanisms
        /// outside Vulkan.
        /// </summary>
        Inherit = 1 << 8, 
    }
}
