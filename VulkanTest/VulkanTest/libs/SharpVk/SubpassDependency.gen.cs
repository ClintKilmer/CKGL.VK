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
    /// Structure specifying a subpass dependency.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubpassDependency
    {
        /// <summary>
        /// 
        /// </summary>
        public SubpassDependency(uint sourceSubpass, uint destinationSubpass, SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, SharpVk.AccessFlags sourceAccessMask, SharpVk.AccessFlags destinationAccessMask, SharpVk.DependencyFlags dependencyFlags)
        {
            this.SourceSubpass = sourceSubpass;
            this.DestinationSubpass = destinationSubpass;
            this.SourceStageMask = sourceStageMask;
            this.DestinationStageMask = destinationStageMask;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
            this.DependencyFlags = dependencyFlags;
        }
        
        /// <summary>
        /// The subpass index of the first subpass in the dependency, or
        /// VK_SUBPASS_EXTERNAL.
        /// </summary>
        public uint SourceSubpass; 
        
        /// <summary>
        /// The subpass index of the second subpass in the dependency, or
        /// VK_SUBPASS_EXTERNAL.
        /// </summary>
        public uint DestinationSubpass; 
        
        /// <summary>
        /// srcStageMask defines a source stage mask.
        /// </summary>
        public SharpVk.PipelineStageFlags SourceStageMask; 
        
        /// <summary>
        /// dstStageMask defines a destination stage mask.
        /// </summary>
        public SharpVk.PipelineStageFlags DestinationStageMask; 
        
        /// <summary>
        /// srcAccessMask defines a source access mask.
        /// </summary>
        public SharpVk.AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// dstAccessMask defines a destination access mask.
        /// </summary>
        public SharpVk.AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// A bitmask of DependencyFlagBits.
        /// </summary>
        public SharpVk.DependencyFlags DependencyFlags; 
    }
}
