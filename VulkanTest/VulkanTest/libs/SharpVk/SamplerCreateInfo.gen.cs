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
    /// Structure specifying parameters of a newly created sampler.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SamplerCreateInfo
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.SamplerCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// The magnification filter to apply to lookups.
        /// </summary>
        public SharpVk.Filter MagFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Filter MinFilter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerMipmapMode MipmapMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeU
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeV
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SamplerAddressMode AddressModeW
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MipLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool AnisotropyEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxAnisotropy
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CompareEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.CompareOp CompareOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.BorderColor BorderColor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool UnnormalizedCoordinates
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.SamplerCreateInfo* pointer)
        {
            pointer->SType = StructureType.SamplerCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.SamplerCreateFlags);
            }
            pointer->MagFilter = this.MagFilter;
            pointer->MinFilter = this.MinFilter;
            pointer->MipmapMode = this.MipmapMode;
            pointer->AddressModeU = this.AddressModeU;
            pointer->AddressModeV = this.AddressModeV;
            pointer->AddressModeW = this.AddressModeW;
            pointer->MipLodBias = this.MipLodBias;
            pointer->AnisotropyEnable = this.AnisotropyEnable;
            pointer->MaxAnisotropy = this.MaxAnisotropy;
            pointer->CompareEnable = this.CompareEnable;
            pointer->CompareOp = this.CompareOp;
            pointer->MinLod = this.MinLod;
            pointer->MaxLod = this.MaxLod;
            pointer->BorderColor = this.BorderColor;
            pointer->UnnormalizedCoordinates = this.UnnormalizedCoordinates;
        }
    }
}
