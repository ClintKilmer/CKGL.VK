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
    public unsafe partial struct ApplicationInfo
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
        /// A string containing the name of the application.
        /// </summary>
        public byte* ApplicationName; 
        
        /// <summary>
        /// The developer-supplied version number of the application.
        /// </summary>
        public uint ApplicationVersion; 
        
        /// <summary>
        /// Astring containing the name of the engine (if any) used to create
        /// the application.
        /// </summary>
        public byte* EngineName; 
        
        /// <summary>
        /// The developer-supplied version number of the engine used to create
        /// the application.
        /// </summary>
        public uint EngineVersion; 
        
        /// <summary>
        /// The version of the Vulkan API against which the application expects
        /// to run. If apiVersion is 0.0.0 the implementation must ignore it,
        /// otherwise if the implementation does not support the requested
        /// apiVersion it must throw IncompatibleDriverException. The patch
        /// version number specified in apiVersion is ignored when creating an
        /// instance object. Only the major and minor versions of the instance
        /// must match those requested in apiVersion.
        /// </summary>
        public uint ApiVersion; 
    }
}
