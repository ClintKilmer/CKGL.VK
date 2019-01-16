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
    /// Structure specifying parameters of a newly created pipeline input
    /// assembly state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineInputAssemblyStateCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.PipelineInputAssemblyStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// A PrimitiveTopology defining the primitive topology, as described
        /// below.
        /// </summary>
        public SharpVk.PrimitiveTopology Topology
        {
            get;
            set;
        }
        
        /// <summary>
        /// primitiveRestartEnable controls whether a special vertex index
        /// value is treated as restarting the assembly of primitives. This
        /// enable only applies to indexed draws (flink:vkCmdDrawIndexed and
        /// flink:vkCmdDrawIndexedIndirect), and the special index value is
        /// either 0xFFFFFFFF when the indexType parameter of
        /// CommandBuffer.BindIndexBuffer is equal to VK_INDEX_TYPE_UINT32, or
        /// 0xFFFF when indexType is equal to VK_INDEX_TYPE_UINT16. Primitive
        /// restart is not allowed for "`list`" topologies.
        /// </summary>
        public bool PrimitiveRestartEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.PipelineInputAssemblyStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineInputAssemblyStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.PipelineInputAssemblyStateCreateFlags);
            }
            pointer->Topology = this.Topology;
            pointer->PrimitiveRestartEnable = this.PrimitiveRestartEnable;
        }
    }
}
