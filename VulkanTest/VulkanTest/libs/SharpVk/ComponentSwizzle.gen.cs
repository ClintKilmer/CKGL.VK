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
    /// Specify how a component is swizzled.
    /// </summary>
    public enum ComponentSwizzle
    {
        /// <summary>
        /// The component is set to the identity swizzle.
        /// </summary>
        Identity = 0, 
        
        /// <summary>
        /// The component is set to zero.
        /// </summary>
        Zero = 1, 
        
        /// <summary>
        /// The component is set to either 1 or 1.0 depending on whether the
        /// type of the image view format is integer or floating-point
        /// respectively, as determined by the Format Definition section for
        /// each Format.
        /// </summary>
        One = 2, 
        
        /// <summary>
        /// The component is set to the value of the R component of the image.
        /// </summary>
        R = 3, 
        
        /// <summary>
        /// The component is set to the value of the G component of the image.
        /// </summary>
        G = 4, 
        
        /// <summary>
        /// The component is set to the value of the B component of the image.
        /// </summary>
        B = 5, 
        
        /// <summary>
        /// The component is set to the value of the A component of the image.
        /// </summary>
        A = 6, 
    }
}
