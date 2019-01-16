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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DebugUtilsMessengerCallbackData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DebugUtilsMessengerCallbackDataFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string MessageIdName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int? MessageIdNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Message
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DebugUtilsLabel[] QueueLabels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DebugUtilsLabel[] CommandBufLabels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.DebugUtilsObjectNameInfo[] Objects
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.DebugUtilsMessengerCallbackData* pointer)
        {
            pointer->SType = StructureType.DebugUtilsMessengerCallbackData;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Multivendor.DebugUtilsMessengerCallbackDataFlags);
            }
            pointer->MessageIdName = Interop.HeapUtil.MarshalTo(this.MessageIdName);
            if (this.MessageIdNumber != null)
            {
                pointer->MessageIdNumber = this.MessageIdNumber.Value;
            }
            else
            {
                pointer->MessageIdNumber = default(int);
            }
            pointer->Message = Interop.HeapUtil.MarshalTo(this.Message);
            pointer->QueueLabelCount = (uint)(Interop.HeapUtil.GetLength(this.QueueLabels));
            if (this.QueueLabels != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.DebugUtilsLabel>(this.QueueLabels.Length).ToPointer());
                for(int index = 0; index < (uint)(this.QueueLabels.Length); index++)
                {
                    this.QueueLabels[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->QueueLabels = fieldPointer;
            }
            else
            {
                pointer->QueueLabels = null;
            }
            pointer->CommandBufLabelCount = (uint)(Interop.HeapUtil.GetLength(this.CommandBufLabels));
            if (this.CommandBufLabels != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.DebugUtilsLabel>(this.CommandBufLabels.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CommandBufLabels.Length); index++)
                {
                    this.CommandBufLabels[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->CommandBufLabels = fieldPointer;
            }
            else
            {
                pointer->CommandBufLabels = null;
            }
            pointer->ObjectCount = (uint)(Interop.HeapUtil.GetLength(this.Objects));
            if (this.Objects != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.DebugUtilsObjectNameInfo>(this.Objects.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Objects.Length); index++)
                {
                    this.Objects[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Objects = fieldPointer;
            }
            else
            {
                pointer->Objects = null;
            }
        }
    }
}
