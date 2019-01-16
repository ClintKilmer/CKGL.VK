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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    public static class PipelineExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Pipeline handle to extend.
        /// </param>
        public static unsafe byte[] GetShaderInfo(this SharpVk.Pipeline extendedHandle, SharpVk.ShaderStageFlags shaderStage, SharpVk.Amd.ShaderInfoType infoType)
        {
            try
            {
                byte[] result = default(byte[]);
                HostSize infoSize = default(HostSize);
                CommandCache commandCache = default(CommandCache);
                byte* marshalledInfo = default(byte*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkPipelineGetShaderInfoDelegate commandDelegate = commandCache.Cache.vkGetShaderInfoAMD;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, shaderStage, infoType, &infoSize, marshalledInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledInfo = (byte*)(Interop.HeapUtil.Allocate<byte>((uint)(infoSize)));
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, shaderStage, infoType, &infoSize, marshalledInfo);
                if (marshalledInfo != null)
                {
                    var fieldPointer = new byte[(uint)(infoSize)];
                    for(int index = 0; index < (uint)(infoSize); index++)
                    {
                        fieldPointer[index] = marshalledInfo[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
