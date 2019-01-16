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
    public static class QueueExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.CheckpointData[] GetCheckpointData(this SharpVk.Queue extendedHandle)
        {
            try
            {
                SharpVk.NVidia.CheckpointData[] result = default(SharpVk.NVidia.CheckpointData[]);
                uint checkpointDataCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.CheckpointData* marshalledCheckpointData = default(SharpVk.Interop.NVidia.CheckpointData*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkQueueGetCheckpointDataDelegate commandDelegate = commandCache.Cache.vkGetQueueCheckpointDataNV;
                commandDelegate(extendedHandle.handle, &checkpointDataCount, marshalledCheckpointData);
                marshalledCheckpointData = (SharpVk.Interop.NVidia.CheckpointData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.CheckpointData>((uint)(checkpointDataCount)));
                commandDelegate(extendedHandle.handle, &checkpointDataCount, marshalledCheckpointData);
                if (marshalledCheckpointData != null)
                {
                    var fieldPointer = new SharpVk.NVidia.CheckpointData[(uint)(checkpointDataCount)];
                    for(int index = 0; index < (uint)(checkpointDataCount); index++)
                    {
                        fieldPointer[index] = SharpVk.NVidia.CheckpointData.MarshalFrom(&marshalledCheckpointData[index]);
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
