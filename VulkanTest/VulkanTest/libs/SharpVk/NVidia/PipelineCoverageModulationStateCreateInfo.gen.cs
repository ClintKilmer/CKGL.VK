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
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PipelineCoverageModulationStateCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.PipelineCoverageModulationStateCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.CoverageModulationMode CoverageModulationMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CoverageModulationTableEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float[] CoverageModulationTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.PipelineCoverageModulationStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineCoverageModulationStateCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.NVidia.PipelineCoverageModulationStateCreateFlags);
            }
            pointer->CoverageModulationMode = this.CoverageModulationMode;
            pointer->CoverageModulationTableEnable = this.CoverageModulationTableEnable;
            pointer->CoverageModulationTableCount = (uint)(Interop.HeapUtil.GetLength(this.CoverageModulationTable));
            if (this.CoverageModulationTable != null)
            {
                var fieldPointer = (float*)(Interop.HeapUtil.AllocateAndClear<float>(this.CoverageModulationTable.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CoverageModulationTable.Length); index++)
                {
                    fieldPointer[index] = this.CoverageModulationTable[index];
                }
                pointer->CoverageModulationTable = fieldPointer;
            }
            else
            {
                pointer->CoverageModulationTable = null;
            }
        }
    }
}
