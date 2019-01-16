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
    /// Structure describing parameters of a queue presentation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PresentInfo
    {
        /// <summary>
        /// If not Null, is an array of Semaphore objects with
        /// waitSemaphoreCount entries, and specifies the semaphores to wait
        /// for before issuing the present request.
        /// </summary>
        public SharpVk.Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SwapchainKHR objects with swapchainCount entries. A
        /// given swapchain must not appear in this list more than once.
        /// </summary>
        public SharpVk.Khronos.Swapchain[] Swapchains
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of indices into the array of each swapchain's presentable
        /// images, with swapchainCount entries. Each entry in this array
        /// identifies the image to present on the corresponding entry in the
        /// pSwapchains array.
        /// </summary>
        public uint[] ImageIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of Result typed elements with swapchainCount entries.
        /// Applications that do not need per-swapchain results can use Null
        /// for pResults. If non-Null, each entry in pResults will be set to
        /// the Result for presenting the swapchain corresponding to the same
        /// index in pSwapchains.
        /// </summary>
        public SharpVk.Result[] Results
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PresentInfo* pointer)
        {
            pointer->SType = StructureType.PresentInfo;
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
            pointer->SwapchainCount = (uint)(Interop.HeapUtil.GetLength(this.Swapchains));
            if (this.Swapchains != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(this.Swapchains.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Swapchains.Length); index++)
                {
                    fieldPointer[index] = this.Swapchains[index]?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                }
                pointer->Swapchains = fieldPointer;
            }
            else
            {
                pointer->Swapchains = null;
            }
            if (this.ImageIndices != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.ImageIndices.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageIndices.Length); index++)
                {
                    fieldPointer[index] = this.ImageIndices[index];
                }
                pointer->ImageIndices = fieldPointer;
            }
            else
            {
                pointer->ImageIndices = null;
            }
            if (this.Results != null)
            {
                var fieldPointer = (SharpVk.Result*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Result>(this.Results.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Results.Length); index++)
                {
                    fieldPointer[index] = this.Results[index];
                }
                pointer->Results = fieldPointer;
            }
            else
            {
                pointer->Results = null;
            }
        }
    }
}
