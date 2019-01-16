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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct CopyDescriptorSet
    {
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// srcSet, srcBinding, and srcArrayElement are the source set,
        /// binding, and array element, respectively.
        /// </summary>
        public SharpVk.Interop.DescriptorSet SourceSet; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceArrayElement; 
        
        /// <summary>
        /// dstSet, dstBinding, and dstArrayElement are the destination set,
        /// binding, and array element, respectively.
        /// </summary>
        public SharpVk.Interop.DescriptorSet DestinationSet; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationArrayElement; 
        
        /// <summary>
        /// The number of descriptors to copy from the source to destination.
        /// If descriptorCount is greater than the number of remaining array
        /// elements in the source or destination binding, those affect
        /// consecutive bindings in a manner similar to WriteDescriptorSet
        /// above.
        /// </summary>
        public uint DescriptorCount; 
    }
}
