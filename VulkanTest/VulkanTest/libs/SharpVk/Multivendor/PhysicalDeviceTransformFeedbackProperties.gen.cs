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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceTransformFeedbackProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTransformFeedbackStreams
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTransformFeedbackBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MaxTransformFeedbackBufferSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTransformFeedbackStreamDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTransformFeedbackBufferDataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTransformFeedbackBufferDataStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TransformFeedbackQueries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TransformFeedbackStreamsLinesTriangles
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TransformFeedbackRasterizationStreamSelect
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TransformFeedbackDraw
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceTransformFeedbackProperties MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackProperties* pointer)
        {
            PhysicalDeviceTransformFeedbackProperties result = default(PhysicalDeviceTransformFeedbackProperties);
            result.MaxTransformFeedbackStreams = pointer->MaxTransformFeedbackStreams;
            result.MaxTransformFeedbackBuffers = pointer->MaxTransformFeedbackBuffers;
            result.MaxTransformFeedbackBufferSize = pointer->MaxTransformFeedbackBufferSize;
            result.MaxTransformFeedbackStreamDataSize = pointer->MaxTransformFeedbackStreamDataSize;
            result.MaxTransformFeedbackBufferDataSize = pointer->MaxTransformFeedbackBufferDataSize;
            result.MaxTransformFeedbackBufferDataStride = pointer->MaxTransformFeedbackBufferDataStride;
            result.TransformFeedbackQueries = pointer->TransformFeedbackQueries;
            result.TransformFeedbackStreamsLinesTriangles = pointer->TransformFeedbackStreamsLinesTriangles;
            result.TransformFeedbackRasterizationStreamSelect = pointer->TransformFeedbackRasterizationStreamSelect;
            result.TransformFeedbackDraw = pointer->TransformFeedbackDraw;
            return result;
        }
    }
}
