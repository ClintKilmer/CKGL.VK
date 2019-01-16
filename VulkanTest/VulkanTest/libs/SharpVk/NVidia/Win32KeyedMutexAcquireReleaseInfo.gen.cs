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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Use Windows keyex mutex mechanism to synchronize work.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Win32KeyedMutexAcquireReleaseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DeviceMemory[] AcquireSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] AcquireKeys
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] AcquireTimeoutMilliseconds
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DeviceMemory[] ReleaseSyncs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong[] ReleaseKeys
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo* pointer)
        {
            pointer->SType = StructureType.Win32KeyedMutexAcquireReleaseInfoNv;
            pointer->Next = null;
            pointer->AcquireCount = (uint)(Interop.HeapUtil.GetLength(this.AcquireSyncs));
            if (this.AcquireSyncs != null)
            {
                var fieldPointer = (SharpVk.Interop.DeviceMemory*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceMemory>(this.AcquireSyncs.Length).ToPointer());
                for(int index = 0; index < (uint)(this.AcquireSyncs.Length); index++)
                {
                    fieldPointer[index] = this.AcquireSyncs[index]?.handle ?? default(SharpVk.Interop.DeviceMemory);
                }
                pointer->AcquireSyncs = fieldPointer;
            }
            else
            {
                pointer->AcquireSyncs = null;
            }
            if (this.AcquireKeys != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(this.AcquireKeys.Length).ToPointer());
                for(int index = 0; index < (uint)(this.AcquireKeys.Length); index++)
                {
                    fieldPointer[index] = this.AcquireKeys[index];
                }
                pointer->AcquireKeys = fieldPointer;
            }
            else
            {
                pointer->AcquireKeys = null;
            }
            if (this.AcquireTimeoutMilliseconds != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(this.AcquireTimeoutMilliseconds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.AcquireTimeoutMilliseconds.Length); index++)
                {
                    fieldPointer[index] = this.AcquireTimeoutMilliseconds[index];
                }
                pointer->AcquireTimeoutMilliseconds = fieldPointer;
            }
            else
            {
                pointer->AcquireTimeoutMilliseconds = null;
            }
            pointer->ReleaseCount = (uint)(Interop.HeapUtil.GetLength(this.ReleaseSyncs));
            if (this.ReleaseSyncs != null)
            {
                var fieldPointer = (SharpVk.Interop.DeviceMemory*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceMemory>(this.ReleaseSyncs.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ReleaseSyncs.Length); index++)
                {
                    fieldPointer[index] = this.ReleaseSyncs[index]?.handle ?? default(SharpVk.Interop.DeviceMemory);
                }
                pointer->ReleaseSyncs = fieldPointer;
            }
            else
            {
                pointer->ReleaseSyncs = null;
            }
            if (this.ReleaseKeys != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(this.ReleaseKeys.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ReleaseKeys.Length); index++)
                {
                    fieldPointer[index] = this.ReleaseKeys[index];
                }
                pointer->ReleaseKeys = fieldPointer;
            }
            else
            {
                pointer->ReleaseKeys = null;
            }
        }
    }
}
