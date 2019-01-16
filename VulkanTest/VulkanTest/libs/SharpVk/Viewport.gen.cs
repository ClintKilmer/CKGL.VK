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
    /// Structure specifying a viewport.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Viewport
    {
        /// <summary>
        /// 
        /// </summary>
        public static Viewport Zero => new Viewport();
        
        /// <summary>
        /// 
        /// </summary>
        public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = minDepth;
            this.MaxDepth = maxDepth;
        }
        
        /// <summary>
        /// x and y are the viewport's upper left corner [eq]#(x,y)#.
        /// </summary>
        public float X; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Y; 
        
        /// <summary>
        /// width and height are the viewport's width and height, respectively.
        /// </summary>
        public float Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Height; 
        
        /// <summary>
        /// minDepth and maxDepth are the depth range for the viewport. It is
        /// valid for minDepth to be greater than or equal to maxDepth.
        /// </summary>
        public float MinDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepth; 
    }
}
