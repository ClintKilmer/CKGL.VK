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
    public enum CompareOp
    {
        /// <summary>
        /// The test never passes.
        /// </summary>
        Never = 0, 
        
        /// <summary>
        /// The test passes when [eq]#R &lt; S#.
        /// </summary>
        Less = 1, 
        
        /// <summary>
        /// The test passes when [eq]#R = S#.
        /// </summary>
        Equal = 2, 
        
        /// <summary>
        /// The test passes when [eq]#R {leq} S#.
        /// </summary>
        LessOrEqual = 3, 
        
        /// <summary>
        /// The test passes when [eq]#R &gt; S#.
        /// </summary>
        Greater = 4, 
        
        /// <summary>
        /// The test passes when [eq]#R {neq} S#.
        /// </summary>
        NotEqual = 5, 
        
        /// <summary>
        /// The test passes when [eq]#R {geq} S#.
        /// </summary>
        GreaterOrEqual = 6, 
        
        /// <summary>
        /// The test always passes.
        /// </summary>
        Always = 7, 
    }
}
