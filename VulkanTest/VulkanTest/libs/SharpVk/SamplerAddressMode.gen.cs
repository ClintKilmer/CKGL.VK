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
    /// Specify behavior of sampling with texture coordinates outside an image.
    /// </summary>
    public enum SamplerAddressMode
    {
        /// <summary>
        /// Indicates that the repeat wrap mode will be used.
        /// </summary>
        Repeat = 0, 
        
        /// <summary>
        /// Indicates that the mirrored repeat wrap mode will be used.
        /// </summary>
        MirroredRepeat = 1, 
        
        /// <summary>
        /// Indicates that the clamp to edge wrap mode will be used.
        /// </summary>
        ClampToEdge = 2, 
        
        /// <summary>
        /// Indicates that the clamp to border wrap mode will be used.
        /// </summary>
        ClampToBorder = 3, 
        
        /// <summary>
        /// Indicates that the mirror clamp to edge wrap mode will be used.
        /// This is only valid if the "VK_KHR_mirror_clamp_to_edge" extension
        /// is enabled.
        /// </summary>
        MirrorClampToEdge = 4, 
    }
}
