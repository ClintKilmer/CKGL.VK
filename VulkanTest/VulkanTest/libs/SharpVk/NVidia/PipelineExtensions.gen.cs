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

namespace SharpVk.NVidia
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
        public static unsafe byte[] GetRayTracingShaderGroupHandles(this SharpVk.Pipeline extendedHandle, uint firstGroup, uint groupCount, HostSize dataSize)
        {
            try
            {
                byte[] result = default(byte[]);
                CommandCache commandCache = default(CommandCache);
                HostSize marshalledDataSize = default(HostSize);
                byte* marshalledData = default(byte*);
                commandCache = extendedHandle.commandCache;
                marshalledDataSize = dataSize;
                marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>(dataSize));
                SharpVk.Interop.NVidia.VkPipelineGetRayTracingShaderGroupHandlesDelegate commandDelegate = commandCache.Cache.vkGetRayTracingShaderGroupHandlesNV;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, firstGroup, groupCount, marshalledDataSize, marshalledData);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledData != null)
                {
                    var fieldPointer = new byte[(uint)(dataSize)];
                    for(int index = 0; index < (uint)(dataSize); index++)
                    {
                        fieldPointer[index] = marshalledData[index];
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Pipeline handle to extend.
        /// </param>
        public static unsafe void CompileDeferred(this SharpVk.Pipeline extendedHandle, uint shader)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkPipelineCompileDeferredDelegate commandDelegate = commandCache.Cache.vkCompileDeferredNV;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, shader);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
