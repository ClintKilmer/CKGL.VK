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
    /// Describes features supported by VK_KHR_shader_float16_int8
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceFloat16Int8Features
    {
        /// <summary>
        /// Indicates whether 16-bit floats (halfs) are supported in shader
        /// code. This also indicates whether shader modules can declare the
        /// Float16 capability.
        /// </summary>
        public bool ShaderFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// Indicates whether 8-bit integers (signed and unsigned) are
        /// supported in shader code. This also indicates whether shader
        /// modules can declare the Int8 capability.
        /// </summary>
        public bool ShaderInt8
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDeviceFloat16Int8Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceFloat16Int8Features;
            pointer->Next = null;
            pointer->ShaderFloat16 = this.ShaderFloat16;
            pointer->ShaderInt8 = this.ShaderInt8;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe PhysicalDeviceFloat16Int8Features MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceFloat16Int8Features* pointer)
        {
            PhysicalDeviceFloat16Int8Features result = default(PhysicalDeviceFloat16Int8Features);
            result.ShaderFloat16 = pointer->ShaderFloat16;
            result.ShaderInt8 = pointer->ShaderInt8;
            return result;
        }
    }
}
