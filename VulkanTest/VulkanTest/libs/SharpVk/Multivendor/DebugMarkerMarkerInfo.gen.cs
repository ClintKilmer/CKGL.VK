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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// Specify parameters of a command buffer marker region.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DebugMarkerMarkerInfo
    {
        /// <summary>
        /// A string that contains the name of the marker.
        /// </summary>
        public string MarkerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// An optional RGBA color value that can be associated with the
        /// marker. A particular implementation may choose to ignore this color
        /// value. The values contain RGBA values in order, in the range 0.0 to
        /// 1.0. If all elements in color are set to 0.0 then it is ignored.
        /// </summary>
        public (float, float, float, float) Color
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo* pointer)
        {
            pointer->SType = StructureType.DebugMarkerMarkerInfo;
            pointer->Next = null;
            pointer->MarkerName = Interop.HeapUtil.MarshalTo(this.MarkerName);
            pointer->Color[0] = this.Color.Item1;
            pointer->Color[1] = this.Color.Item2;
            pointer->Color[2] = this.Color.Item3;
            pointer->Color[3] = this.Color.Item4;
        }
    }
}
