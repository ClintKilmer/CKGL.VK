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
    /// Structure specifying parameters of a newly created instance.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct InstanceCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.InstanceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </summary>
        public SharpVk.ApplicationInfo? ApplicationInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </summary>
        public ArrayProxy<string> EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </summary>
        public ArrayProxy<string> EnabledExtensionNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.InstanceCreateInfo* pointer)
        {
            pointer->SType = StructureType.InstanceCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.InstanceCreateFlags);
            }
            if (this.ApplicationInfo != null)
            {
                pointer->ApplicationInfo = (SharpVk.Interop.ApplicationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ApplicationInfo>());
                this.ApplicationInfo.Value.MarshalTo(pointer->ApplicationInfo);
            }
            else
            {
                pointer->ApplicationInfo = default(SharpVk.Interop.ApplicationInfo*);
            }
            pointer->EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(this.EnabledLayerNames));
            pointer->EnabledLayerNames = Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
            pointer->EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(this.EnabledExtensionNames));
            pointer->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
        }
    }
}
