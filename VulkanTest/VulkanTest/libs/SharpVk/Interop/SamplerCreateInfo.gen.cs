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
    public unsafe partial struct SamplerCreateInfo
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
        public SharpVk.SamplerCreateFlags Flags; 
        
        /// <summary>
        /// The magnification filter to apply to lookups.
        /// </summary>
        public SharpVk.Filter MagFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Filter MinFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerMipmapMode MipmapMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeU; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeV; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeW; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MipLodBias; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AnisotropyEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxAnisotropy; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 CompareEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.CompareOp CompareOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.BorderColor BorderColor; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 UnnormalizedCoordinates; 
    }
}
