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
    /// Structure specifying parameters for the generation of commands.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CommandProcessCommandsInfo
    {
        /// <summary>
        /// The ObjectTableNVX to be used for the generation process. Only
        /// registered objects at the time
        /// flink:vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.
        /// </summary>
        public SharpVk.NVidia.Experimental.ObjectTable ObjectTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// The IndirectCommandsLayoutNVX that provides the command sequence to
        /// generate.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pIndirectCommandsTokens provides an array of
        /// IndirectCommandsTokenNVX that reference the input data for each
        /// token command.
        /// </summary>
        public SharpVk.NVidia.Experimental.IndirectCommandsToken[] IndirectCommandsTokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// The maximum number of sequences for which command buffer space will
        /// be reserved. If sequencesCountBuffer is null, this is also the
        /// actual number of sequences generated.
        /// </summary>
        public uint MaxSequencesCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// targetCommandBuffer can be the secondary CommandBuffer in which the
        /// commands should be recorded. If targetCommandBuffer is Null an
        /// implicit reservation as well as execution takes place on the
        /// processing CommandBuffer.
        /// </summary>
        public SharpVk.CommandBuffer TargetCommandBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// sequencesCountBuffer can be Buffer from which the actual amount of
        /// sequences is sourced from as ftext:uint32_t value.
        /// </summary>
        public SharpVk.Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The byte offset into sequencesCountBuffer where the count value is
        /// stored.
        /// </summary>
        public DeviceSize? SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// sequencesIndexBuffer must be set if indirectCommandsLayout's
        /// VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT is set and
        /// provides the used sequence indices as ftext:uint32_t array.
        /// Otherwise it must be null.
        /// </summary>
        public SharpVk.Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The byte offset into sequencesIndexBuffer where the index values
        /// start.
        /// </summary>
        public DeviceSize? SequencesIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo* pointer)
        {
            pointer->SType = StructureType.CommandProcessCommandsInfo;
            pointer->Next = null;
            pointer->ObjectTable = this.ObjectTable?.handle ?? default(SharpVk.Interop.NVidia.Experimental.ObjectTable);
            pointer->IndirectCommandsLayout = this.IndirectCommandsLayout?.handle ?? default(SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout);
            pointer->IndirectCommandsTokenCount = (uint)(Interop.HeapUtil.GetLength(this.IndirectCommandsTokens));
            if (this.IndirectCommandsTokens != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken>(this.IndirectCommandsTokens.Length).ToPointer());
                for(int index = 0; index < (uint)(this.IndirectCommandsTokens.Length); index++)
                {
                    this.IndirectCommandsTokens[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->IndirectCommandsTokens = fieldPointer;
            }
            else
            {
                pointer->IndirectCommandsTokens = null;
            }
            pointer->MaxSequencesCount = this.MaxSequencesCount;
            pointer->TargetCommandBuffer = this.TargetCommandBuffer?.handle ?? default(SharpVk.Interop.CommandBuffer);
            pointer->SequencesCountBuffer = this.SequencesCountBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            if (this.SequencesCountOffset != null)
            {
                pointer->SequencesCountOffset = this.SequencesCountOffset.Value;
            }
            else
            {
                pointer->SequencesCountOffset = default(DeviceSize);
            }
            pointer->SequencesIndexBuffer = this.SequencesIndexBuffer?.handle ?? default(SharpVk.Interop.Buffer);
            if (this.SequencesIndexOffset != null)
            {
                pointer->SequencesIndexOffset = this.SequencesIndexOffset.Value;
            }
            else
            {
                pointer->SequencesIndexOffset = default(DeviceSize);
            }
        }
    }
}
