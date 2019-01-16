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
    /// Stencil comparison function.
    /// </summary>
    public enum StencilOp
    {
        /// <summary>
        /// Keeps the current value.
        /// </summary>
        Keep = 0, 
        
        /// <summary>
        /// Sets the value to 0.
        /// </summary>
        Zero = 1, 
        
        /// <summary>
        /// Sets the value to reference.
        /// </summary>
        Replace = 2, 
        
        /// <summary>
        /// Increments the current value and clamps to the maximum
        /// representable unsigned value.
        /// </summary>
        IncrementAndClamp = 3, 
        
        /// <summary>
        /// decrements the current value and clamps to 0.
        /// </summary>
        DecrementAndClamp = 4, 
        
        /// <summary>
        /// Bitwise-inverts the current value.
        /// </summary>
        Invert = 5, 
        
        /// <summary>
        /// Increments the current value and wraps to 0 when the maximum value
        /// would have been exceeded.
        /// </summary>
        IncrementAndWrap = 6, 
        
        /// <summary>
        /// Decrements the current value and wraps to the maximum possible
        /// value when the value would go below 0.
        /// </summary>
        DecrementAndWrap = 7, 
    }
}
