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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ObjectTablePushConstantEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectEntryUsageFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineLayout PipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags StageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.ObjectTablePushConstantEntry* pointer)
        {
            pointer->Type = this.Type;
            pointer->Flags = this.Flags;
            pointer->PipelineLayout = this.PipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
            pointer->StageFlags = this.StageFlags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe ObjectTablePushConstantEntry MarshalFrom(SharpVk.Interop.NVidia.Experimental.ObjectTablePushConstantEntry* pointer)
        {
            ObjectTablePushConstantEntry result = default(ObjectTablePushConstantEntry);
            result.Type = pointer->Type;
            result.Flags = pointer->Flags;
            result.PipelineLayout = new SharpVk.PipelineLayout(default(SharpVk.Device), pointer->PipelineLayout);
            result.StageFlags = pointer->StageFlags;
            return result;
        }
    }
}
