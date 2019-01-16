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
    /// Structure specifying a queue submit operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SubmitInfo
    {
        /// <summary>
        /// An array of semaphores upon which to wait before the command
        /// buffers for this batch begin execution. If semaphores to wait on
        /// are provided, they define a semaphore wait operation.
        /// </summary>
        public SharpVk.Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of pipeline stages at which each corresponding semaphore
        /// wait will occur.
        /// </summary>
        public SharpVk.PipelineStageFlags[] WaitDestinationStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of command buffers to execute in the batch.
        /// </summary>
        public SharpVk.CommandBuffer[] CommandBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of semaphores which will be signaled when the command
        /// buffers for this batch have completed execution. If semaphores to
        /// be signaled are provided, they define a semaphore signal operation.
        /// </summary>
        public SharpVk.Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.SubmitInfo* pointer)
        {
            pointer->SType = StructureType.SubmitInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(this.WaitSemaphores));
            if (this.WaitSemaphores != null)
            {
                var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(this.WaitSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.WaitSemaphores[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                }
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            if (this.WaitDestinationStageMask != null)
            {
                var fieldPointer = (SharpVk.PipelineStageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PipelineStageFlags>(this.WaitDestinationStageMask.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitDestinationStageMask.Length); index++)
                {
                    fieldPointer[index] = this.WaitDestinationStageMask[index];
                }
                pointer->WaitDestinationStageMask = fieldPointer;
            }
            else
            {
                pointer->WaitDestinationStageMask = null;
            }
            pointer->CommandBufferCount = (uint)(Interop.HeapUtil.GetLength(this.CommandBuffers));
            if (this.CommandBuffers != null)
            {
                var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(this.CommandBuffers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CommandBuffers.Length); index++)
                {
                    fieldPointer[index] = this.CommandBuffers[index]?.handle ?? default(SharpVk.Interop.CommandBuffer);
                }
                pointer->CommandBuffers = fieldPointer;
            }
            else
            {
                pointer->CommandBuffers = null;
            }
            pointer->SignalSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(this.SignalSemaphores));
            if (this.SignalSemaphores != null)
            {
                var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(this.SignalSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SignalSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.SignalSemaphores[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                }
                pointer->SignalSemaphores = fieldPointer;
            }
            else
            {
                pointer->SignalSemaphores = null;
            }
        }
    }
}
