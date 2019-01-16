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
    /// Structure specifying a sparse binding operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct BindSparseInfo
    {
        /// <summary>
        /// An array of semaphores upon which to wait on before the sparse
        /// binding operations for this batch begin execution. If semaphores to
        /// wait on are provided, they define a semaphore wait operation.
        /// </summary>
        public SharpVk.Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseBufferMemoryBindInfo structures.
        /// </summary>
        public SharpVk.SparseBufferMemoryBindInfo[] BufferBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseImageOpaqueMemoryBindInfo structures, indicating
        /// opaque sparse image bindings to perform.
        /// </summary>
        public SharpVk.SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseImageMemoryBindInfo structures, indicating sparse
        /// image bindings to perform.
        /// </summary>
        public SharpVk.SparseImageMemoryBindInfo[] ImageBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of semaphores which will be signaled when the sparse
        /// binding operations for this batch have completed execution. If
        /// semaphores to be signaled are provided, they define a semaphore
        /// signal operation.
        /// </summary>
        public SharpVk.Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.BindSparseInfo* pointer)
        {
            pointer->SType = StructureType.BindSparseInfo;
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
            pointer->BufferBindCount = (uint)(Interop.HeapUtil.GetLength(this.BufferBinds));
            if (this.BufferBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseBufferMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseBufferMemoryBindInfo>(this.BufferBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.BufferBinds.Length); index++)
                {
                    this.BufferBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferBinds = fieldPointer;
            }
            else
            {
                pointer->BufferBinds = null;
            }
            pointer->ImageOpaqueBindCount = (uint)(Interop.HeapUtil.GetLength(this.ImageOpaqueBinds));
            if (this.ImageOpaqueBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseImageOpaqueMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseImageOpaqueMemoryBindInfo>(this.ImageOpaqueBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageOpaqueBinds.Length); index++)
                {
                    this.ImageOpaqueBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageOpaqueBinds = fieldPointer;
            }
            else
            {
                pointer->ImageOpaqueBinds = null;
            }
            pointer->ImageBindCount = (uint)(Interop.HeapUtil.GetLength(this.ImageBinds));
            if (this.ImageBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseImageMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseImageMemoryBindInfo>(this.ImageBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageBinds.Length); index++)
                {
                    this.ImageBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageBinds = fieldPointer;
            }
            else
            {
                pointer->ImageBinds = null;
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
