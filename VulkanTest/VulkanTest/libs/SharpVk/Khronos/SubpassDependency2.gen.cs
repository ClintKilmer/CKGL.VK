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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDependency2
    {
        /// <summary>
        /// 
        /// </summary>
        public uint SourceSubpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationSubpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags SourceStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.PipelineStageFlags DestinationStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AccessFlags? SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.AccessFlags? DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DependencyFlags? DependencyFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int? ViewOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.SubpassDependency2* pointer)
        {
            pointer->SType = StructureType.SubpassDependency2;
            pointer->Next = null;
            pointer->SourceSubpass = this.SourceSubpass;
            pointer->DestinationSubpass = this.DestinationSubpass;
            pointer->SourceStageMask = this.SourceStageMask;
            pointer->DestinationStageMask = this.DestinationStageMask;
            if (this.SourceAccessMask != null)
            {
                pointer->SourceAccessMask = this.SourceAccessMask.Value;
            }
            else
            {
                pointer->SourceAccessMask = default(SharpVk.AccessFlags);
            }
            if (this.DestinationAccessMask != null)
            {
                pointer->DestinationAccessMask = this.DestinationAccessMask.Value;
            }
            else
            {
                pointer->DestinationAccessMask = default(SharpVk.AccessFlags);
            }
            if (this.DependencyFlags != null)
            {
                pointer->DependencyFlags = this.DependencyFlags.Value;
            }
            else
            {
                pointer->DependencyFlags = default(SharpVk.DependencyFlags);
            }
            if (this.ViewOffset != null)
            {
                pointer->ViewOffset = this.ViewOffset.Value;
            }
            else
            {
                pointer->ViewOffset = default(int);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe SubpassDependency2 MarshalFrom(SharpVk.Interop.Khronos.SubpassDependency2* pointer)
        {
            SubpassDependency2 result = default(SubpassDependency2);
            result.SourceSubpass = pointer->SourceSubpass;
            result.DestinationSubpass = pointer->DestinationSubpass;
            result.SourceStageMask = pointer->SourceStageMask;
            result.DestinationStageMask = pointer->DestinationStageMask;
            result.SourceAccessMask = pointer->SourceAccessMask;
            result.DestinationAccessMask = pointer->DestinationAccessMask;
            result.DependencyFlags = pointer->DependencyFlags;
            result.ViewOffset = pointer->ViewOffset;
            return result;
        }
    }
}
