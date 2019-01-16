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
    public unsafe partial struct PipelineColorBlendAttachmentState
    {
        /// <summary>
        /// blendEnable controls whether blending is enabled for the
        /// corresponding color attachment. If blending is not enabled, the
        /// source fragment's color for that attachment is passed through
        /// unmodified.
        /// </summary>
        public Bool32 BlendEnable; 
        
        /// <summary>
        /// srcColorBlendFactor selects which blend factor is used to determine
        /// the source factors [eq]#(S~r~,S~g~,S~b~)#.
        /// </summary>
        public SharpVk.BlendFactor SourceColorBlendFactor; 
        
        /// <summary>
        /// dstColorBlendFactor selects which blend factor is used to determine
        /// the destination factors [eq]#(D~r~,D~g~,D~b~)#.
        /// </summary>
        public SharpVk.BlendFactor DestinationColorBlendFactor; 
        
        /// <summary>
        /// colorBlendOp selects which blend operation is used to calculate the
        /// RGB values to write to the color attachment.
        /// </summary>
        public SharpVk.BlendOp ColorBlendOp; 
        
        /// <summary>
        /// srcAlphaBlendFactor selects which blend factor is used to determine
        /// the source factor [eq]#S~a~#.
        /// </summary>
        public SharpVk.BlendFactor SourceAlphaBlendFactor; 
        
        /// <summary>
        /// dstAlphaBlendFactor selects which blend factor is used to determine
        /// the destination factor [eq]#D~a~#.
        /// </summary>
        public SharpVk.BlendFactor DestinationAlphaBlendFactor; 
        
        /// <summary>
        /// alphaBlendOp selects which blend operation is use to calculate the
        /// alpha values to write to the color attachment.
        /// </summary>
        public SharpVk.BlendOp AlphaBlendOp; 
        
        /// <summary>
        /// A bitmask selecting which of the R, G, B, and/or A components are
        /// enabled for writing, as described later in this chapter.
        /// </summary>
        public SharpVk.ColorComponentFlags ColorWriteMask; 
    }
}
