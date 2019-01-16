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
    public unsafe partial struct InstanceCreateInfo
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
        /// Reserved for future use.
        /// </summary>
        public SharpVk.InstanceCreateFlags Flags; 
        
        /// <summary>
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </summary>
        public SharpVk.Interop.ApplicationInfo* ApplicationInfo; 
        
        /// <summary>
        /// The number of global layers to enable.
        /// </summary>
        public uint EnabledLayerCount; 
        
        /// <summary>
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </summary>
        public byte** EnabledLayerNames; 
        
        /// <summary>
        /// The number of global extensions to enable.
        /// </summary>
        public uint EnabledExtensionCount; 
        
        /// <summary>
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </summary>
        public byte** EnabledExtensionNames; 
    }
}
