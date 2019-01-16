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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GeometryTriangles
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer VertexData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize VertexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VertexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize VertexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format VertexFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer IndexData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize IndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint IndexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.IndexType IndexType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Buffer TransformData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize TransformOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GeometryTriangles* pointer)
        {
            pointer->SType = StructureType.GeometryTriangles;
            pointer->Next = null;
            pointer->VertexData = this.VertexData?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->VertexOffset = this.VertexOffset;
            pointer->VertexCount = this.VertexCount;
            pointer->VertexStride = this.VertexStride;
            pointer->VertexFormat = this.VertexFormat;
            pointer->IndexData = this.IndexData?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->IndexOffset = this.IndexOffset;
            pointer->IndexCount = this.IndexCount;
            pointer->IndexType = this.IndexType;
            pointer->TransformData = this.TransformData?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->TransformOffset = this.TransformOffset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe GeometryTriangles MarshalFrom(SharpVk.Interop.NVidia.GeometryTriangles* pointer)
        {
            GeometryTriangles result = default(GeometryTriangles);
            result.VertexData = new SharpVk.Buffer(default(SharpVk.Device), pointer->VertexData);
            result.VertexOffset = pointer->VertexOffset;
            result.VertexCount = pointer->VertexCount;
            result.VertexStride = pointer->VertexStride;
            result.VertexFormat = pointer->VertexFormat;
            result.IndexData = new SharpVk.Buffer(default(SharpVk.Device), pointer->IndexData);
            result.IndexOffset = pointer->IndexOffset;
            result.IndexCount = pointer->IndexCount;
            result.IndexType = pointer->IndexType;
            result.TransformData = new SharpVk.Buffer(default(SharpVk.Device), pointer->TransformData);
            result.TransformOffset = pointer->TransformOffset;
            return result;
        }
    }
}
