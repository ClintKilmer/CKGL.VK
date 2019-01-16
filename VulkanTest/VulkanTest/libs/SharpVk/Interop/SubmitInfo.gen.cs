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
    public unsafe partial struct SubmitInfo
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
        /// The number of semaphores upon which to wait before executing the
        /// command buffers for the batch.
        /// </summary>
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// An array of semaphores upon which to wait before the command
        /// buffers for this batch begin execution. If semaphores to wait on
        /// are provided, they define a semaphore wait operation.
        /// </summary>
        public SharpVk.Interop.Semaphore* WaitSemaphores; 
        
        /// <summary>
        /// An array of pipeline stages at which each corresponding semaphore
        /// wait will occur.
        /// </summary>
        public SharpVk.PipelineStageFlags* WaitDestinationStageMask; 
        
        /// <summary>
        /// The number of command buffers to execute in the batch.
        /// </summary>
        public uint CommandBufferCount; 
        
        /// <summary>
        /// An array of command buffers to execute in the batch.
        /// </summary>
        public SharpVk.Interop.CommandBuffer* CommandBuffers; 
        
        /// <summary>
        /// The number of semaphores to be signaled once the commands specified
        /// in pCommandBuffers have completed execution.
        /// </summary>
        public uint SignalSemaphoreCount; 
        
        /// <summary>
        /// An array of semaphores which will be signaled when the command
        /// buffers for this batch have completed execution. If semaphores to
        /// be signaled are provided, they define a semaphore signal operation.
        /// </summary>
        public SharpVk.Interop.Semaphore* SignalSemaphores; 
    }
}
