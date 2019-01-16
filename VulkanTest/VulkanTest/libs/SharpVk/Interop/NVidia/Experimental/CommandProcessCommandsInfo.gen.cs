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

namespace SharpVk.Interop.NVidia.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct CommandProcessCommandsInfo
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
        /// The ObjectTableNVX to be used for the generation process. Only
        /// registered objects at the time
        /// flink:vkCmdReserveSpaceForCommandsNVX is called, will be taken into
        /// account for the reservation.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.ObjectTable ObjectTable; 
        
        /// <summary>
        /// The IndirectCommandsLayoutNVX that provides the command sequence to
        /// generate.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.IndirectCommandsLayout IndirectCommandsLayout; 
        
        /// <summary>
        /// indirectCommandsTokenCount defines the number of input tokens used.
        /// </summary>
        public uint IndirectCommandsTokenCount; 
        
        /// <summary>
        /// pIndirectCommandsTokens provides an array of
        /// IndirectCommandsTokenNVX that reference the input data for each
        /// token command.
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.IndirectCommandsToken* IndirectCommandsTokens; 
        
        /// <summary>
        /// The maximum number of sequences for which command buffer space will
        /// be reserved. If sequencesCountBuffer is null, this is also the
        /// actual number of sequences generated.
        /// </summary>
        public uint MaxSequencesCount; 
        
        /// <summary>
        /// targetCommandBuffer can be the secondary CommandBuffer in which the
        /// commands should be recorded. If targetCommandBuffer is Null an
        /// implicit reservation as well as execution takes place on the
        /// processing CommandBuffer.
        /// </summary>
        public SharpVk.Interop.CommandBuffer TargetCommandBuffer; 
        
        /// <summary>
        /// sequencesCountBuffer can be Buffer from which the actual amount of
        /// sequences is sourced from as ftext:uint32_t value.
        /// </summary>
        public SharpVk.Interop.Buffer SequencesCountBuffer; 
        
        /// <summary>
        /// The byte offset into sequencesCountBuffer where the count value is
        /// stored.
        /// </summary>
        public DeviceSize SequencesCountOffset; 
        
        /// <summary>
        /// sequencesIndexBuffer must be set if indirectCommandsLayout's
        /// VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT is set and
        /// provides the used sequence indices as ftext:uint32_t array.
        /// Otherwise it must be null.
        /// </summary>
        public SharpVk.Interop.Buffer SequencesIndexBuffer; 
        
        /// <summary>
        /// The byte offset into sequencesIndexBuffer where the index values
        /// start.
        /// </summary>
        public DeviceSize SequencesIndexOffset; 
    }
}
