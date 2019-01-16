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
    /// Bitmask controlling swapchain creation.
    /// </summary>
    [System.Flags]
    public enum SwapchainCreateFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SplitInstanceBindRegions = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Protected = 1 << 1, 
        
        /// <summary>
        /// Specifies that the images of the swapchain can be used to create an
        /// ImageView with different format than what the swapchain was created
        /// with. The list of allowed image view formats are specified by
        /// submitting an instance of ImageFormatListCreateInfo to
        /// Device.CreateSwapchain. In addition, this flag also specifies that
        /// the swapchain can be created with usage flags that are not
        /// supported for the format the swapchain is created with but are
        /// supported for at least one of the allowed image view formats.
        /// </summary>
        MutableFormat = 1 << 2, 
    }
}
